using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraMode
{
    DefaultCamera, FarCamera, FirstPersonCamera
}

public class ChangeCamera : MonoBehaviour
{

    public GameObject defaultCamera;

    public GameObject farCamera;

    public GameObject firstPersonCamera;

    public GameObject defaultBackCamera;

    public GameObject farBackCamera;

    public GameObject firstPersonBackCamera;

    public CameraMode cameraMode;

    private bool isBackCameraEnabled = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            cameraMode = (CameraMode)(((int)++cameraMode) % 3);
        }
        if (Input.GetButtonDown("LookBack"))
        {
            isBackCameraEnabled = true;
        }
        if (Input.GetButtonUp("LookBack"))
        {
            isBackCameraEnabled = false;
        }

        StartCoroutine(ChangeMode());
    }

    IEnumerator ChangeMode()
    {
        yield return new WaitForSeconds(0.01f);

        if (cameraMode == CameraMode.DefaultCamera)
        {
            if (isBackCameraEnabled)
            {
                defaultBackCamera.SetActive(true);
                defaultCamera.SetActive(false);
            }
            else
            {
                defaultCamera.SetActive(true);
                defaultBackCamera.SetActive(false);
            }

            firstPersonCamera.SetActive(false);
            firstPersonBackCamera.SetActive(false);
        }
        else if (cameraMode == CameraMode.FarCamera)
        {
            if (isBackCameraEnabled)
            {
                farBackCamera.SetActive(true);
                farCamera.SetActive(false);
            }
            else
            {
                farCamera.SetActive(true);
                farBackCamera.SetActive(false);
            }

            defaultCamera.SetActive(false);
            defaultBackCamera.SetActive(false);
        }
        else if (cameraMode == CameraMode.FirstPersonCamera)
        {
            if (isBackCameraEnabled)
            {
                firstPersonBackCamera.SetActive(true);
                firstPersonCamera.SetActive(false);
            }
            else
            {
                firstPersonCamera.SetActive(true);
                firstPersonBackCamera.SetActive(false);
            }

            farCamera.SetActive(false);
            farBackCamera.SetActive(false);
        }
    }
}
