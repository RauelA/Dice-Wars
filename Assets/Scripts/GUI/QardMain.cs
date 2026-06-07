using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QardMain : MonoBehaviour
{
    private QardInstantiator _qardInstantiator;



    void Start()
    {
        _qardInstantiator = GetComponent<QardInstantiator>();

        /* TEST!

        _qardInstantiator.CreateQardByName("Peasant Militia",       (2 * Vector3.up + 2 * Vector3.right) * 200);
        _qardInstantiator.CreateQardByName("Iron Orc",              (2 * Vector3.up + 4 * Vector3.right) * 200);
        _qardInstantiator.CreateQardByName("Silver Demon",          (2 * Vector3.up + 6 * Vector3.right) * 200);
        _qardInstantiator.CreateQardByName("Blackdragon of Death",  (2 * Vector3.up + 8 * Vector3.right) * 200);

        */

    }
}
