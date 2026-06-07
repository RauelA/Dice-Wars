using System.Collections.Generic;
using UnityEngine;

public class HoverPopup : MonoBehaviour
{
    private UIMain _uiMain;

    private void Start()
    {
        _uiMain = GameObject.Find("GAME").GetComponent<UIMain>();
    }
    private void OnMouseEnter()
    {
        _uiMain.OpenCubeHoverPopup(gameObject);
    }

}