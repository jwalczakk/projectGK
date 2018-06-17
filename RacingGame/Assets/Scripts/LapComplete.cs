using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa rejestrujaca wzbudzenie punktu kontrolnego bedacego koncem okrazenia
/// </summary>
public class LapComplete : MonoBehaviour
{
    /// <summary>
    /// Koncowy punkt kontrolny
    /// </summary>
    public GameObject LapCompleteTrig;

    // Player One
    /// <summary>
    /// Pole wyswietlajace minuty najlepszego czasu gracza nr 1
    /// </summary>
    public GameObject BestMinuteDisplay1;
    /// <summary>
    /// Pole wyswietlajace sekundy najlepszego czasu gracza nr 1
    /// </summary>
    public GameObject BestSecondDisplay1;
    /// <summary>
    /// Pole wyswietlajace milisekundy najlepszego czasu gracza nr 1
    /// </summary>
    public GameObject BestMillisecondDisplay1;
    public GameObject LapTimeBox1;
    /// <summary>
    /// Pole wyswietlajace licznik okrazen ukonczonych przez gracza nr 1
    /// </summary>
    public GameObject LapCounter1;
    /// <summary>
    /// Licznik okrazen ukonczonych przez gracza nr 1
    /// </summary>
    public int LapsDone1;
    /// <summary>
    /// Licznik minut najlepszego okrazenia gracza nr 1
    /// </summary>
    private int BestMinuteCount1 = int.MaxValue;
    /// <summary>
    /// Licznik sekund najlepszego okrazenia gracza nr 1
    /// </summary>
    private int BestSecondCount1 = int.MaxValue;
    /// <summary>
    /// Licznik milisekund najlepszego okrazenia gracza nr 1
    /// </summary>
    private float BestMillisecondCount1 = int.MaxValue;

    //Player Two
    /// <summary>
    /// Pole wyswietlajace minuty najlepszego czasu gracza nr 2
    /// </summary>
    public GameObject BestMinuteDisplay2;
    /// <summary>
    /// Pole wyswietlajace sekundy najlepszego czasu gracza nr 2
    /// </summary>
    public GameObject BestSecondDisplay2;
    /// <summary>
    /// Pole wyswietlajace milisekundy najlepszego czasu gracza nr 2
    /// </summary>
    public GameObject BestMillisecondDisplay2;
    public GameObject LapTimeBox2;
    /// <summary>
    /// Pole wyswietlajace licznik okrazen ukonczonych przez gracza nr 2
    /// </summary>
    public GameObject LapCounter2;
    /// <summary>
    /// Licznik okrazen ukonczonych przez gracza nr 2
    /// </summary>
    public int LapsDone2;
    /// <summary>
    /// Licznik minut najlepszego okrazenia gracza nr 2
    /// </summary>
    private int BestMinuteCount2 = int.MaxValue;
    /// <summary>
    /// Licznik sekund najlepszego okrazenia gracza nr 2
    /// </summary>
    private int BestSecondCount2 = int.MaxValue;
    /// <summary>
    /// Licznik milisekund najlepszego okrazenia gracza nr 2
    /// </summary>
    private float BestMillisecondCount2 = int.MaxValue;

    /// <summary>
    /// Liczba okrazen wymaganych do przejechania
    /// </summary>
    public int LapsRequirement;

    /// <summary>
    /// Wyzwalacz ukonczenia wyscigu
    /// </summary>
    public GameObject RaceFinish;

    /// <summary>
    /// Kontroler punktow kontrolnych
    /// </summary>
    public CheckpointsController Controller;

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.tag == "PlayerOne")
        {
            if (!Controller.OnPlayerOneTriggeredCheckpoint(LapCompleteTrig))
            {
                return;
            }
            OnPlayerOneTriggerEnter();
        }
        else if (other.attachedRigidbody.tag == "PlayerTwo")
        {
            if (!Controller.OnPlayerTwoTriggeredCheckpoint(LapCompleteTrig))
            {
                return;
            }
            OnPlayerTwoTriggerEnter();
        }
        else
        {
            return;
        }
    }

    /// <summary>
    /// Wzbudzenie punktu kontrolnego przez gracza nr 1
    /// </summary>
    private void OnPlayerOneTriggerEnter()
    {
        LapsDone1 += 1;

        if (LapsDone1 == LapsRequirement)
        {
            Controller.PlayerOneFinished = true;
        }

        if (LapTimeManager.MinuteCount1 < BestMinuteCount1
            || (LapTimeManager.MinuteCount1 == BestMinuteCount1
                && (LapTimeManager.SecondCount1 < BestSecondCount1
                    || (LapTimeManager.SecondCount1 == BestSecondCount1
                        && LapTimeManager.MilisecondCount1 < BestMillisecondCount1))))
        {
            BestMinuteCount1 = LapTimeManager.MinuteCount1;
            BestSecondCount1 = LapTimeManager.SecondCount1;
            BestMillisecondCount1 = LapTimeManager.MilisecondCount1;


            if (BestSecondCount1 <= 9)
            {
                BestSecondDisplay1.GetComponent<Text>().text = "0" + BestSecondCount1 + ".";
            }
            else
            {
                BestSecondDisplay1.GetComponent<Text>().text = "" + BestSecondCount1 + ".";
            }

            if (BestMinuteCount1 <= 9)
            {
                BestMinuteDisplay1.GetComponent<Text>().text = "0" + BestMinuteCount1 + ":";
            }
            else
            {
                BestMinuteDisplay1.GetComponent<Text>().text = "" + BestMinuteCount1 + ":";
            }

            BestMillisecondDisplay1.GetComponent<Text>().text = "" + BestMillisecondCount1;

        }

        LapTimeManager.MinuteCount1 = 0;
        LapTimeManager.SecondCount1 = 0;
        LapTimeManager.MilisecondCount1 = 0;

        LapCounter1.GetComponent<Text>().text = "" + LapsDone1;
    }

    /// <summary>
    /// Wzbudzenie punktu kontrolnego przez gracza nr 2
    /// </summary>
    private void OnPlayerTwoTriggerEnter()
    {
        LapsDone2 += 1;

        if (LapsDone2 == LapsRequirement)
        {
            Controller.PlayerOneFinished = true;
        }

        if (LapTimeManager.MinuteCount2 < BestMinuteCount2
            || (LapTimeManager.MinuteCount2 == BestMinuteCount2
                && (LapTimeManager.SecondCount2 < BestSecondCount2
                    || (LapTimeManager.SecondCount2 == BestSecondCount2
                        && LapTimeManager.MilisecondCount2 < BestMillisecondCount2))))
        {
            BestMinuteCount2 = LapTimeManager.MinuteCount2;
            BestSecondCount2 = LapTimeManager.SecondCount2;
            BestMillisecondCount2 = LapTimeManager.MilisecondCount2;


            if (BestSecondCount2 <= 9)
            {
                BestSecondDisplay2.GetComponent<Text>().text = "0" + BestSecondCount2 + ".";
            }
            else
            {
                BestSecondDisplay2.GetComponent<Text>().text = "" + BestSecondCount2 + ".";
            }

            if (BestMinuteCount2 <= 9)
            {
                BestMinuteDisplay2.GetComponent<Text>().text = "0" + BestMinuteCount2 + ":";
            }
            else
            {
                BestMinuteDisplay2.GetComponent<Text>().text = "" + BestMinuteCount2 + ":";
            }

            BestMillisecondDisplay2.GetComponent<Text>().text = "" + BestMillisecondCount2;

        }

        LapTimeManager.MinuteCount2 = 0;
        LapTimeManager.SecondCount2 = 0;
        LapTimeManager.MilisecondCount2 = 0;

        LapCounter2.GetComponent<Text>().text = "" + LapsDone2;
    }

}
