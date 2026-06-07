using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeGO : MonoBehaviour
{
    public float ShuffleThrowPower;
    public float ShuffleRotationPower;

    public float StandardIntensity = 2;
    public float HighlightMaxIntensity = 5;
    public float RotateCorrectionSpeed;

    public MeshRenderer[] SideRenderers;
    public MeshRenderer[] FrameRenderers;

    [HideInInspector] public CubeData CubeData;

    private Rigidbody _rigidbody;
    private HighlightGlowMain _highlightGlowMain;
    private SoundMain _soundMain;
    private int _topSide;
    private bool _isRolling;
    private bool _isHighlighting;
    private bool _isCorrectingRotation;
    private float _highlightingProgress;
    private float _rotationCorrectionProgress;
    private Material _currentTopSideMaterial;
    private Vector3 _startRotation; 
    private Vector3 _targetRotation; 

    void Start()
    {
        _rigidbody              = GetComponent<Rigidbody>();
        _highlightGlowMain      = GameObject.Find("GAME").GetComponent<HighlightGlowMain>();
        _soundMain              = GameObject.Find("GAME").GetComponent<SoundMain>();

        _isRolling              = false;
        _isHighlighting         = false;
        _isCorrectingRotation   = false;

        ResetRenderers();
    }

    private void Update()
    {
        if (!_isHighlighting)
        {
            ResetRenderers();
        }

        if (transform.position.y >= 1)
        {
            _isRolling = true;
        }

        if (_isRolling)
        {

            _topSide = GetTopSide(); // No top side => Returns -1

            if (_topSide != -1)
            {
                Debug.Log($"Top-Side = {_topSide}");

                _isRolling = false;
                StartRotationCorrection();
            }
        }

        if (_isCorrectingRotation)
        {
            _rotationCorrectionProgress += RotateCorrectionSpeed * Time.deltaTime;

            if (_rotationCorrectionProgress >= 1f)
            {
                Quaternion rotation = Quaternion.Euler(_targetRotation);

                _rigidbody.maxAngularVelocity = 0;

                _rigidbody.MoveRotation(rotation);

                _isCorrectingRotation = false;

                StartHighlightSequence();
            }
            else
            {
                // Init Renderers
                for (int i = 0; i < SideRenderers.Length; i++)
                {
                    if (SideRenderers[i] != null)
                    {
                        Material material = SideRenderers[i].material;
                        material.enableInstancing = true;
                        material.EnableKeyword("_EMISSION");
                        material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
                    }
                }

                ResetRotation();
            }
        }
        else if (_isHighlighting)
        {
            float intensity = _highlightGlowMain.HighlightEffectIntensityCurve.Evaluate(_highlightingProgress);

            // Update the emission color and intensity of the material.
            _currentTopSideMaterial.SetColor("_EmissionColor", Color.white * intensity);
            // Makes the renderer update the emission and albedo maps of our material.
            RendererExtensions.UpdateGIMaterials(SideRenderers[_topSide]);
            // Inform Unity's GI system to recalculate GI based on the new emission map.
            DynamicGI.SetEmissive(SideRenderers[_topSide], Color.white * intensity);
            DynamicGI.UpdateEnvironment();


            _highlightingProgress += _highlightGlowMain.AnimationSpeed * Time.deltaTime;
            if (_highlightingProgress >= 1)
            {
                _isHighlighting = false;
            }
        }

    }
    public void Shuffle()
    {
        Vector3 torque = new Vector3(UnityEngine.Random.Range(1f, 2f), UnityEngine.Random.Range(1f, 2f), UnityEngine.Random.Range(1f, 2f));

        Vector3 torque2 = Vector3.Cross(torque, Vector3.up);

        if (UnityEngine.Random.Range(0f, 1f) > 0.5f)
        { 
            torque = -torque;
        }
        if (UnityEngine.Random.Range(0f, 1f) > 0.5f)
        {
            torque2 = -torque2;
        }

        _rigidbody.maxAngularVelocity = ShuffleRotationPower;

        _rigidbody.AddForce(Vector3.up * ShuffleThrowPower);

        _rigidbody.AddTorque(torque * ShuffleRotationPower);

        _rigidbody.AddTorque(torque2 * ShuffleRotationPower);

        _isHighlighting = false;
    }

    private void ResetRotation()
    {
        Vector3 euler = Vector3.LerpUnclamped(_startRotation, _targetRotation, _rotationCorrectionProgress);

        Quaternion rotation = Quaternion.Euler(euler);

        _rigidbody.MoveRotation(rotation);
    }

    private void ResetRenderers()
    {
        foreach (MeshRenderer renderer in SideRenderers)
        {
            // Update the emission color and intensity of the material.
            renderer.material.SetColor("_EmissionColor", Color.white * StandardIntensity);
            // Makes the renderer update the emission and albedo maps of our material.
            RendererExtensions.UpdateGIMaterials(renderer);
            // Inform Unity's GI system to recalculate GI based on the new emission map.
            DynamicGI.SetEmissive(renderer, Color.white * StandardIntensity);
        }
        DynamicGI.UpdateEnvironment();
    }

    private void StartHighlightSequence()
    {
        _isHighlighting         = true;
        _highlightingProgress   = 0;

        _currentTopSideMaterial = SideRenderers[_topSide].material;

        if (CubeData.Abilities[_topSide] != E.A.EMPTY)
        {
            Instantiate(_highlightGlowMain.GetHighlightEffect(CubeData.Abilities[_topSide]), SideRenderers[_topSide].transform, false);

            _soundMain.PlayCubeHighlightSound();
        }

    }

    private void StartRotationCorrection()
    {
        _isCorrectingRotation = true;
        _rotationCorrectionProgress = 0;
    }

    public int GetTopSide()
    {
        int topSide = -1;

        _startRotation = transform.rotation.eulerAngles;

        _startRotation = new Vector3(Mathf.Round(_startRotation.x), Mathf.Round(_startRotation.y), Mathf.Round(_startRotation.z));

        if (_startRotation.x == 0 && _startRotation.z == 0)
        {
            topSide = 0;
                        
            _targetRotation = new Vector3(0, 0, 0);
        }
        else if (_startRotation.x == 90)
        {
            topSide = 1;

            _targetRotation = new Vector3(90, 0, 0);
        }
        else if (_startRotation.x == 0 && _startRotation.z == 90)
        {
            topSide = 2;

            _targetRotation = new Vector3(0, 90, 90);
        }
        else if (_startRotation.x == 0 && _startRotation.z == 270)
        {
            topSide = 3;

            _targetRotation = new Vector3(0, 0, 270);
        }
        else if (_startRotation.x == 270)
        {
            topSide = 4;

            _targetRotation = new Vector3(270, 180, 0);
        }
        else if (_startRotation.x == 180 && _startRotation.z == 0)
        {
            topSide = 5;

            _targetRotation = new Vector3(180, 0, 0);
        }
        else if (_startRotation.x == 0 && _startRotation.z == 180)
        {
            topSide = 5;

            _targetRotation = new Vector3(0, 180, 180);
        }

        return topSide;
    }

}
