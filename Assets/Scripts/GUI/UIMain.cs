using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIMain : MonoBehaviour
{
    public bool IsInGUI = false;

    public List<GameObject> AllPopups; // All current popups


    public GameObject CanvasMain;
    public GameObject CubeHoverPopupPrefab;
    public GameObject CubeHighlightPrefab;

    public float PopupDuration;
    public float PopupStartHeight;
    public Vector3 PopupOffset;

    public Transform CurrentChosenCubeTransform;
    private GameObject _cubeHoverPopup; // Eine Referenz auf das Popup-GameObject
    private GameObject _cubeHighlightObject; // Eine Referenz auf das Highlight-GameObject
    private float _cubeHoverPopupStartTime; // Die Startzeit des Popup-Animations-Timers


    void FixedUpdate()
    {
        IsInGUI = EventSystem.current.IsPointerOverGameObject();

        if (AllPopups.Count != 0)
        {
            ProgressCubeHoverPopup();
        }
    }



    private void ProgressCubeHoverPopup()
    {
        Vector3 popupStartPosition = _cubeHoverPopup.transform.position;
        Vector3 popupTargetPosition = popupStartPosition + PopupOffset;

        // Zeige das Popup-GameObject und das Highlight-GameObject an
        if (_cubeHoverPopup != null && _cubeHighlightObject != null)
        {
            _cubeHoverPopup.SetActive(true);
            _cubeHighlightObject.SetActive(true);

            float elapsedTime = Time.time - _cubeHoverPopupStartTime;

            if (elapsedTime < PopupDuration)
            {
                // Aktualisiere die Popup-Position
                float popupProgress = Mathf.Clamp01(elapsedTime / PopupDuration);
                Vector3 newPosition = Vector3.Lerp(popupStartPosition, popupTargetPosition, popupProgress);
                _cubeHoverPopup.transform.position = newPosition;
            }
            else if (!IsInGUI)
            {
                CloseAllPopups();
            }
        }
    }


    public void OpenCubeHoverPopup(GameObject cube)
    {
        CloseAllPopups();

        CurrentChosenCubeTransform = cube.transform;

        _cubeHoverPopup = Instantiate(CubeHoverPopupPrefab, CanvasMain.transform);

        AllPopups.Add(_cubeHoverPopup);

        _cubeHoverPopup.transform.position = Camera.main.WorldToScreenPoint(CurrentChosenCubeTransform.position + Vector3.up * PopupStartHeight + PopupOffset);

        _cubeHighlightObject = Instantiate(CubeHighlightPrefab, CurrentChosenCubeTransform.position, CurrentChosenCubeTransform.rotation);

        _cubeHoverPopupStartTime = Time.time;
    }


    public void CloseAllPopups()
    {
        foreach (GameObject popup in AllPopups)
        {
            Destroy(popup);
        }
        AllPopups.Clear();

        Destroy(_cubeHighlightObject);
    }

}
