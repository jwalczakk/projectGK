using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CheckpointTrigger : MonoBehaviour
{

    public GameObject NextTrigger;
    public GameObject CurrentTrigger;
    public CheckpointsController Controller;

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.tag == "PlayerOne") {
            Controller.OnPlayerOneTriggeredCheckpoint(CurrentTrigger);
        }
        else if (other.attachedRigidbody.tag == "PlayerTwo") {
            Controller.OnPlayerTwoTriggeredCheckpoint(CurrentTrigger);
        }
        //{
        //    NextTrigger.SetActive(true);
        //    CurrentTrigger.SetActive(false);
        //}
    }
}
