using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Typ wyliczeniowy zawierajacy dostepne tryby kamery
/// </summary>
public enum CameraMode
{
    DefaultCamera, FarCamera, FirstPersonCamera
}

/// <summary>
/// Klasa odpowiadajaca za przelaczanie trybow kamery samochodu
/// </summary>
public class ChangeCamera : MonoBehaviour
{
    /// <summary>
    /// Domyslna kamera (blisko pojazdu)
    /// </summary>
    public GameObject defaultCamera;

    /// <summary>
    /// Kamera poscigowa (daleko pojazdu)
    /// </summary>
    public GameObject farCamera;

    /// <summary>
    /// Kamera pierwszej osoby
    /// </summary>
    public GameObject firstPersonCamera;

    /// <summary>
    /// Wsteczna domyslna kamera (blisko pojazdu)
    /// </summary>
    public GameObject defaultBackCamera;

    /// <summary>
    /// Wsteczna kamera poscigowa (daleko pojazdu)
    /// </summary>
    public GameObject farBackCamera;

    /// <summary>
    /// Wsteczna kamera pierwszej osoby
    /// </summary>
    public GameObject firstPersonBackCamera;

    /// <summary>
    /// Wybrany tryb kamery
    /// </summary>
    public CameraMode cameraMode;

    /// <summary>
    /// Stan wyboru wstecznej kamery
    /// </summary>
    private bool isBackCameraEnabled = false;
    /// <summary>
    /// Czy uzywac alternatywnych przyciskow (dla gracza nr 2)
    /// </summary>
    public bool UseAlternativeButtons;

    // Update is called once per frame
    void Update()
    {
        if (!UseAlternativeButtons)
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
        }
        else
        {
            if (Input.GetButtonDown("CameraAlt"))
            {
                cameraMode = (CameraMode)(((int)++cameraMode) % 3);
            }
            if (Input.GetButtonDown("LookBackAlt"))
            {
                isBackCameraEnabled = true;
            }
            if (Input.GetButtonUp("LookBackAlt"))
            {
                isBackCameraEnabled = false;
            }
        }

        StartCoroutine(ChangeMode());
    }

    /// <summary>
    /// Zmiana trybu kamery
    /// </summary>
    /// <returns></returns>
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

            CameraStable.SetStabilizationState(true);
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

            CameraStable.SetStabilizationState(true);
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

            CameraStable.SetStabilizationState(false);
            farCamera.SetActive(false);
            farBackCamera.SetActive(false);
        }
    }
}
