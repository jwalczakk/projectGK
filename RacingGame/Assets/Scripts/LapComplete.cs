using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject NextTrigger;

    // Player One
    public GameObject BestMinuteDisplay1;
    public GameObject BestSecondDisplay1;
    public GameObject BestMillisecondDisplay1;
    public GameObject LapTimeBox1;
    public GameObject LapCounter1;
    public int LapsDone1;
    private int BestMinuteCount1 = int.MaxValue;
    private int BestSecondCount1 = int.MaxValue;
    private float BestMillisecondCount1 = int.MaxValue;

    //Player Two
    public GameObject BestMinuteDisplay2;
    public GameObject BestSecondDisplay2;
    public GameObject BestMillisecondDisplay2;
    public GameObject LapTimeBox2;
    public GameObject LapCounter2;
    public int LapsDone2;
    private int BestMinuteCount2 = int.MaxValue;
    private int BestSecondCount2 = int.MaxValue;
    private float BestMillisecondCount2 = int.MaxValue;

    public int LapsRequirement;

    public GameObject RaceFinish;

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
        
        //NextTrigger.SetActive(true);
        //LapCompleteTrig.SetActive(false);
    }

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
