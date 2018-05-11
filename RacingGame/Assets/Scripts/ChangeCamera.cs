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

    public CameraMode cameraMode;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            cameraMode = (CameraMode)(((int)++cameraMode) % 3);
        }

        StartCoroutine(ChangeMode());
    }

    IEnumerator ChangeMode()
    {
        yield return new WaitForSeconds(0.01f);

        if (cameraMode == CameraMode.DefaultCamera)
        {
            defaultCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
        }
        else if (cameraMode == CameraMode.FarCamera)
        {
            farCamera.SetActive(true);
            defaultCamera.SetActive(false);
        }
        else if (cameraMode == CameraMode.FirstPersonCamera)
        {
            firstPersonCamera.SetActive(true);
            farCamera.SetActive(false);
        }
    }
}
