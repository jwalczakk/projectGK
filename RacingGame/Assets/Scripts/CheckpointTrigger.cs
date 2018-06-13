using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{

    public GameObject NextTrigger;
    public GameObject CurrentTrigger;

    void OnTriggerEnter()
    {
        NextTrigger.SetActive(true);
        CurrentTrigger.SetActive(false);
    }
}
