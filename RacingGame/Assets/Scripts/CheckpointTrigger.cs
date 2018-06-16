using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CheckpointTrigger : MonoBehaviour
{

    public GameObject NextTrigger;
    public GameObject CurrentTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            NextTrigger.SetActive(true);
            CurrentTrigger.SetActive(false);
        }
    }
}
