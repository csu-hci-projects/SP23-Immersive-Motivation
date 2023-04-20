using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMouse : MonoBehaviour
{
    public GameObject surveyCanvas;
    public GameObject playerCam;
    public GameObject staticCam;

    void Update()
    {
        if (surveyCanvas.activeInHierarchy)
        {
            setActive();
        }
    }

    public void setActive()
    {
        playerCam.SetActive(false);
        staticCam.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void setInactive()
    {
        playerCam.SetActive(true);
        staticCam.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}