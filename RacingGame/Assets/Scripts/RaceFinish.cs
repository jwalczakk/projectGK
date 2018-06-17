using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{

    public GameObject[] Cars;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject CompleteTrig;
    public GameObject Timer;
    public GameObject CarAudio;
    public AudioSource FinishMusicSource;

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
