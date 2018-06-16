using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject CompleteTrig;
    public GameObject Timer;
    public GameObject CarAudio;
    public AudioSource FinishMusicSource;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CarAudio.SetActive(false);
        CompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        Timer.SetActive(false);
        MyCar.GetComponent<CarController>().enabled = false;
        MyCar.GetComponent<CarUserControl>().enabled = false;
        MyCar.GetComponent<AudioSource>().enabled = false;
        MyCar.SetActive(true);
        FinishCam.SetActive(true);
        ViewModes.SetActive(false);
        FinishMusicSource.Play();
    }
}
