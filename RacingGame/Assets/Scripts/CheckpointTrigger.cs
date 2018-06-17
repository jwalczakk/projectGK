using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/// <summary>
/// Klasa rejestrujaca wzbudzenie punktu kontrolnego
/// </summary>
public class CheckpointTrigger : MonoBehaviour
{
    /// <summary>
    /// Ten punkt kontrolny
    /// </summary>
    public GameObject CurrentTrigger;
    /// <summary>
    /// Kontroler punktow kontrolnych
    /// </summary>
    public CheckpointsController Controller;

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.tag == "PlayerOne") {
            Controller.OnPlayerOneTriggeredCheckpoint(CurrentTrigger);
        }
        else if (other.attachedRigidbody.tag == "PlayerTwo") {
            Controller.OnPlayerTwoTriggeredCheckpoint(CurrentTrigger);
        }
    }
}
