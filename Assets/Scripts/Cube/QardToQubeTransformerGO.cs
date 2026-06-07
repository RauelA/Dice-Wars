using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DissolveExample;

public class QardToQubeTransformerGO : MonoBehaviour
{
    public Material MainTextureMaterial;

    public Vector4 DisolveOffsetStart = new Vector4(0, 0.08f ,0 ,0);
    public Vector4 DisolveOffsetEnd = new Vector4(0, -0.05f, 0, 0);

    public float EdgeWidthStart = 0;
    public float EdgeWidthEnd = 1;

    public float AnimationSpeed;

    public float DurationPhase1 = 60;
    public float DurationPhase2 = 60;
    public float DurationPhase3 = 20;

    public Material ShineMaterial;

    public Material DissolveMaterial;

    public Light[] LightSources;

    public Transform PlaneTop;
    public Transform PlaneCenter;
    public Transform PlaneLeft;
    public Transform PlaneRight;
    public Transform PlaneBottom;
    public Transform PlaneVeryBottom;

    private float _animationProgress = 0;
    private float _animationProgressPercentage = 0;

    private HighlightGlowMain _hiGlMain;

    private int _currentPhase;

    private void Awake()
    {
        _hiGlMain = GameObject.Find("GAME").GetComponent<HighlightGlowMain>();

        MainTextureMaterial.SetVector("_DissolveOffest", DisolveOffsetStart);

        MainTextureMaterial.SetFloat("_EdgeWidth", EdgeWidthStart);

        _currentPhase = 1;
    }

    void Update()
    {
        // PHASE 1
        //
        if (_currentPhase == 1)
        {
            Debug.Log("Doing Phase 0...");

            _animationProgress += AnimationSpeed * Time.deltaTime;
            _animationProgressPercentage = _animationProgress / DurationPhase1;


            Vector4 dissolveOffsetCurrent = (DisolveOffsetStart * (1 - _animationProgressPercentage)) + (DisolveOffsetEnd * _animationProgressPercentage);
            float edgeWidthCurrent = (EdgeWidthStart * (1 - _animationProgressPercentage)) + (EdgeWidthEnd * _animationProgressPercentage);

            MainTextureMaterial.SetVector("_DissolveOffest", dissolveOffsetCurrent);
            MainTextureMaterial.SetFloat("_EdgeWidth", edgeWidthCurrent);


            foreach (Light light in LightSources)
            {
                light.intensity = _hiGlMain.LightIntensityCurve.Evaluate(_animationProgressPercentage) * 2;
            }

            if (_animationProgressPercentage > 0.5f)
            {
                ShineMaterial.color = new Color(1, 1, 1, _hiGlMain.HighlightEffectIntensityCurve.Evaluate(_animationProgressPercentage - 0.5f));
            }


            if (_animationProgressPercentage >= 1)
            {
                _currentPhase = 2;

                _animationProgress = 0;
                _animationProgressPercentage = 0;
            }
        }


        // PHASE 1
        //
        else if (_currentPhase == 2)
        {
            Debug.Log("Doing Phase 1...");

            float angle = 38f / DurationPhase2;


            transform.RotateAround(PlaneCenter.position - new Vector3(0, 0.5f * Vector3.Distance(PlaneCenter.position, PlaneTop.position), 0), PlaneTop.forward, angle * 0.2f);
            transform.RotateAround(PlaneCenter.position - new Vector3(0, 0.5f * Vector3.Distance(PlaneCenter.position, PlaneTop.position), 0), PlaneTop.up, angle * 0.2f);
            transform.RotateAround(PlaneCenter.position - new Vector3(0, 0.5f * Vector3.Distance(PlaneCenter.position, PlaneTop.position), 0), PlaneTop.right, angle * 0.2f);


            PlaneTop        .RotateAround(PlaneCenter.position + PlaneCenter.forward * PlaneCenter.localScale.x * 5, PlaneTop.right, angle);
            PlaneLeft       .RotateAround(PlaneCenter.position - PlaneCenter.right * PlaneCenter.localScale.x * 5, PlaneLeft.forward, angle);
            PlaneRight      .RotateAround(PlaneCenter.position + PlaneCenter.right * PlaneCenter.localScale.x * 5, PlaneRight.forward, -angle);
            PlaneBottom     .RotateAround(PlaneCenter.position - PlaneCenter.forward * PlaneCenter.localScale.x * 5, PlaneBottom.right, -angle);
            PlaneVeryBottom .RotateAround(PlaneBottom.position - PlaneBottom.forward * PlaneCenter.localScale.x * 5, PlaneVeryBottom.right, -angle);


            _animationProgress += AnimationSpeed * Time.deltaTime;

            _animationProgressPercentage = _animationProgress / DurationPhase2;

            if (_animationProgressPercentage > 0.5f)
            {
                ShineMaterial.color = new Color(1, 1, 1, _hiGlMain.HighlightEffectIntensityCurve.Evaluate(_animationProgressPercentage));
            }



            if (_animationProgressPercentage > 1)
            {
                _currentPhase = 3;
                /*
                PlaneTop        .localPosition.Set(0, -5, 5);
                PlaneBottom     .localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
                PlaneLeft       .localPosition.Set(-5, -5, 0);
                PlaneLeft       .localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
                PlaneRight      .localPosition.Set(5, -5, 0);
                PlaneRight      .localRotation = Quaternion.Euler(new Vector3(0, 0, -90));
                PlaneBottom     .localPosition.Set(0, -5, -5);
                PlaneBottom     .localRotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                PlaneVeryBottom .localPosition.Set(0, -5, -5);
                PlaneVeryBottom .localRotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                */
            }
        }



        // PHASE 2
        //
        else if (_currentPhase == 3)
        {

            Debug.Log("Doing Phase 0...");

            _animationProgress += AnimationSpeed * Time.deltaTime;

            _animationProgressPercentage = _animationProgress / DurationPhase3;


            if (_animationProgressPercentage >= 1)
            {
                _currentPhase = 4;
            }



            if (_animationProgressPercentage >= 9999)
            {
                gameObject.SetActive(false);

                MainTextureMaterial.SetVector("_DissolveOffest", DisolveOffsetStart);
                MainTextureMaterial.SetFloat("_EdgeWidth", EdgeWidthStart);

                Destroy(gameObject);
            }



        }


    }
}
