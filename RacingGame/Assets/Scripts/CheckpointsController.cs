using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Klasa zarzadzajaca punktami kontrolnymi na trasie
/// </summary>
public class CheckpointsController : MonoBehaviour {

    /// <summary>
    /// Lista punktow kontrolnych
    /// </summary>
    public List<GameObject> Checkpoints;

    /// <summary>
    /// Liczba punktow kontrolnych
    /// </summary>
    private int Length;

    /// <summary>
    /// Indeks punktu kontrolnego znajdujacego sie przed samochodem nr 1
    /// </summary>
    private int CarOneIndex = 1;

    /// <summary>
    /// Indeks punktu kontrolnego znajdujacego sie przed samochodem nr 2
    /// </summary>
    private int CarTwoIndex = 1;

    private bool PlayerOneFinishedField = false;

    private bool PlayerTwoFinishedField = false;

    /// <summary>
    /// Czy gracz nr 2 ukonczyl wyscig
    /// </summary>
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

    /// <summary>
    /// Czy gracz nr 1 ukonczyl wyscig
    /// </summary>
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
	
    /// <summary>
    /// Metoda wyzwalana przy przekroczeniu punktu kontrolnego przez gracza nr 1
    /// </summary>
    /// <param name="trigger">punkt kontrolny</param>
    /// <returns>true, jesli punkt kontrolny zostal wzbudzony w odpowiedniej kolejnosci; false - w przeciwnym razie</returns>
    public bool OnPlayerOneTriggeredCheckpoint(GameObject trigger)
    {
        if (Checkpoints.IndexOf(trigger) == CarOneIndex)
        {
            CarOneIndex = (CarOneIndex + 1) % Length;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Metoda wyzwalana przy przekroczeniu punktu kontrolnego przez gracza nr 2
    /// </summary>
    /// <param name="trigger">punkt kontrolny</param>
    /// <returns>true, jesli punkt kontrolny zostal wzbudzony w odpowiedniej kolejnosci; false - w przeciwnym razie</returns>
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
