using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardGO : MonoBehaviour
{
    public TextMeshProUGUI Title;

    public Image PortraitImage;
    public Image RaceBackground;

    public Image[] AbilityIcons;
    public Image[] AbilityFrameCorners;
    public Image[] AbilityFrameSmallEdges;
    public Image[] AbilityFrameBigEdges;
    public Image[] AbilityFrameOuterFrame;

    [HideInInspector] public CubeData CubeData;

    public void Awake()
    {

    }
}


