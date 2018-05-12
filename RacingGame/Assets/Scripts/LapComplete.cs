using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject BestMinuteDisplay;
    public GameObject BestSecondDisplay;
    public GameObject BestMillisecondDisplay;

    private int BestMinuteCount = int.MaxValue;
    private int BestSecondCount = int.MaxValue;
    private float BestMillisecondCount = int.MaxValue;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {

        if (LapTimeManager.MinuteCount < BestMinuteCount
            || (LapTimeManager.MinuteCount == BestMinuteCount
                && (LapTimeManager.SecondCount < BestSecondCount
                    || (LapTimeManager.SecondCount == BestSecondCount
                        && LapTimeManager.MilisecondCount < BestMillisecondCount))))
        {
            BestMinuteCount = LapTimeManager.MinuteCount;
            BestSecondCount = LapTimeManager.SecondCount;
            BestMillisecondCount = LapTimeManager.MilisecondCount;


            if (BestSecondCount <= 9)
            {
                BestSecondDisplay.GetComponent<Text>().text = "0" + BestSecondCount + ".";
            }
            else
            {
                BestSecondDisplay.GetComponent<Text>().text = "" + BestSecondCount + ".";
            }

            if (BestMinuteCount <= 9)
            {
                BestMinuteDisplay.GetComponent<Text>().text = "0" + BestMinuteCount + ":";
            }
            else
            {
                BestMinuteDisplay.GetComponent<Text>().text = "" + BestMinuteCount + ":";
            }

            BestMillisecondDisplay.GetComponent<Text>().text = "" + BestMillisecondCount;

        }

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilisecondCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}