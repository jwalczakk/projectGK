using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointsController : MonoBehaviour {

    public List<GameObject> Checkpoints;

    private int Length;

    private int CarOneIndex = 1;

    private int CarTwoIndex = 1;

    private bool PlayerOneFinishedField = false;

    private bool PlayerTwoFinishedField = false;

    public bool PlayerTwoFinished
    {
        get
        {
            return PlayerTwoFinishedField;
        }

        set
        {
            PlayerTwoFinishedField = value;
        }
    }

    public bool PlayerOneFinished
    {
        get
        {
            return PlayerOneFinishedField;
        }

        set
        {
            PlayerOneFinishedField = value;
        }
    }

    // Use this for initialization
    void Start () {
        Length = Checkpoints.Count;
        CarOneIndex = 0;
        CarTwoIndex = 0;
	}
	
    public bool OnPlayerOneTriggeredCheckpoint(GameObject trigger)
    {
        if (Checkpoints.IndexOf(trigger) == CarOneIndex)
        {
            CarOneIndex = (CarOneIndex + 1) % Length;
            return true;
        }
        return false;
    }

    public bool OnPlayerTwoTriggeredCheckpoint(GameObject trigger)
    {
        if (Checkpoints.IndexOf(trigger) == CarTwoIndex)
        {
            CarTwoIndex = (CarTwoIndex + 1) % Length;
            return true;
        }
        return false;
    }
}
