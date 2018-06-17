using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/// <summary>
/// Klasa odpowiadajaca za wyzwolenie wydarzenia konca wyscigu od punktu do punktu
/// </summary>
public class SprintRaceFinish : MonoBehaviour
{
    /// <summary>
    /// Samochod
    /// </summary>
    public GameObject MyCar;
    /// <summary>
    /// Kamera koncowa
    /// </summary>
    public GameObject FinishCam;
    public GameObject ViewModes;
    /// <summary>
    /// Menedzer pomiaru czasu
    /// </summary>
    public GameObject Timer;
    /// <summary>
    /// Dzwiek ukonczenia wyscigu
    /// </summary>
    public AudioSource FinishMusicSource;
    /// <summary>
    /// Przycisk powrotu do menu glownego
    /// </summary>
    public GameObject MainMenuButton;

    void OnTriggerEnter()
    {
        MainMenuButton.SetActive(true);
        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        Timer.SetActive(false);
        MyCar.GetComponent<CarController>().enabled = false;
        MyCar.GetComponent<CarUserControl>().enabled = false;
        MyCar.GetComponent<AudioSource>().enabled = false;
        FinishCam.SetActive(true);
        MyCar.SetActive(true);
        ViewModes.SetActive(false);
        FinishMusicSource.Play();
    }
}


