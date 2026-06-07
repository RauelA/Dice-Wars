using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TEST !
using UnityEngine.UI;

public class CubeMain : MonoBehaviour
{
    private List<GameObject> AllCubes;
    private CubeInstantiator CubeInstantiator;


    // TEST !
    public Button TestButton;


    void Start()
    {
        AllCubes = new List<GameObject>();

        CubeInstantiator = GetComponent<CubeInstantiator>();

        // TEST!

        CubeInstantiator                        .CreateCubeByName("Peasant Militia",        Vector3.up + Vector3.left);
        CubeInstantiator                        .CreateCubeByName("Iron Orc",               Vector3.up);
        GameObject testCube = CubeInstantiator  .CreateCubeByName("Silver Demon",           Vector3.up + Vector3.right);
        CubeInstantiator                        .CreateCubeByName("Blackdragon of Death",   Vector3.up + Vector3.right + Vector3.right);

        AllCubes.Add(testCube);



        TestButton.onClick.AddListener(delegate () { testCube.GetComponent<CubeGO>().Shuffle(); });
    }
}
