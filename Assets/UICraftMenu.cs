using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UICraftMenu : MonoBehaviour
{
    public GameObject AbilityFilterOn;
    public GameObject AbilityFilterOff;
    public Button AbilityFilterButton;

    private bool isAbilityFilterActive = false;

    public void AbilityFilterButtonClicked()
    {
        isAbilityFilterActive = !isAbilityFilterActive;
        AbilityFilterOn.SetActive(isAbilityFilterActive);
        AbilityFilterOff.SetActive(!isAbilityFilterActive);
    }


}
