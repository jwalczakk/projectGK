using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/// <summary>
/// Klasa odpowiadajaca za wyzwolenie wydarzenia konca wyscigu na zamknietym torze
/// </summary>
public class RaceFinish : MonoBehaviour
{
    /// <summary>
    /// Samochody uczestniczace w wyscigu
    /// </summary>
    public GameObject[] Cars;
    /// <summary>
    /// Kamera koncowa
    /// </summary>
    public GameObject FinishCam;

    public GameObject ViewModes;
    /// <summary>
    /// Koncowy punkt kontrolny
    /// </summary>
    public GameObject CompleteTrig;
    /// <summary>
    /// Menedzer pomiaru czasu
    /// </summary>
    public GameObject Timer;
    /// <summary>
    /// Dzwiek samochodu
    /// </summary>
    public GameObject CarAudio;
    /// <summary>
    /// Dzwiek ukonczenia wyscigu
    /// </summary>
    public AudioSource FinishMusicSource;
    /// <summary>
    /// Kontroler punktow kontrolnych
    /// </summary>
    public CheckpointsController Controller;

    void OnTriggerEnter(Collider other)
    {
        GameObject car = null;
        foreach (GameObject item in Cars)
        {
            if (other.attachedRigidbody == item.GetComponent<Rigidbody>())
            {
                car = item;
            }
        }

        if (car != null && ((car.tag == "PlayerOne" && Controller.PlayerOneFinished)
            || (car.tag == "PlayerTwo" && Controller.PlayerTwoFinished)))
        {

            this.GetComponent<BoxCollider>().enabled = false;

            car.SetActive(false);
            //CarAudio.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Timer.SetActive(false);
            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;
            car.GetComponent<AudioSource>().enabled = false;
            car.SetActive(true);

            FinishCam.SetActive(true);
            ViewModes.SetActive(false);
            FinishMusicSource.Play();
        }
    }
}
