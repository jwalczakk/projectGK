using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject[] FinishCams;

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
    /// <summary>
    /// Wiadomosc koncowa, wynik wyscigu
    /// </summary>
    public GameObject FinishMessage;
    /// <summary>
    /// Przycisk powrotu do menu glownego
    /// </summary>
    public GameObject MainMenuButton;


    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

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

        bool PlayerOne = (car.tag == "PlayerOne" && Controller.PlayerOneFinished);
        bool PlayerTwo = (car.tag == "PlayerTwo" && Controller.PlayerTwoFinished);

        if (car != null && (PlayerOne)
            || (PlayerTwo))
        {
            FinishMessage.SetActive(true);
            // MainMenuButton.SetActive(true);
            GameObject FinishCam = FinishCams[0];
            if (PlayerOne)
            {
                FinishMessage.GetComponent<Text>().text = "PLAYER ONE WON";
            }
            if (PlayerTwo)
            {
                FinishCam = FinishCams[1];
                FinishMessage.GetComponent<Text>().text = "PLAYER TWO WON";
            }

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
