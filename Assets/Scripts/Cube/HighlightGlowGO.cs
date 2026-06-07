using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightGlowGO : MonoBehaviour
{
    public Material ShineMaterial;

    public Light LightSource;

    public Color ShineColor;

    private float _animationCounter = 0;

    private HighlightGlowMain _hiGlMain;

    private void Awake()
    {
        _hiGlMain = GameObject.Find("GAME").GetComponent<HighlightGlowMain>();
    }

    void Update()
    {
        transform.localPosition.Set(0, -0.22f + 0.22f * _hiGlMain.HighlightEffectIntensityCurve.Evaluate(_animationCounter), 0);

        _animationCounter += Time.deltaTime * _hiGlMain.AnimationSpeed;

        LightSource.intensity = _hiGlMain.LightIntensityCurve.Evaluate(_animationCounter);
        LightSource.range =     _hiGlMain.LightIntensityCurve.Evaluate(_animationCounter) * _hiGlMain.LightRangeFactor;

        ShineMaterial.color = new Color(ShineColor.r,
                                        ShineColor.g,
                                        ShineColor.b,
                                        _hiGlMain.HighlightEffectIntensityCurve.Evaluate(_animationCounter));

        if (_animationCounter >= 1)
        {
            Destroy(gameObject);
        }
    }
}
