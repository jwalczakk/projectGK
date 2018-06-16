using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public GameObject CountDown;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject LapRequirementBox;

    public GameObject LapCompleteTrigger;

    public AudioSource GetReady;
    public AudioSource GoAudio;

	void Start ()
    {
        StartCoroutine(CountStart());
        LapRequirementBox.GetComponent<Text>().text = string.Format("/ {0}", LapCompleteTrigger.GetComponent<LapComplete>().LapsRequirement);
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(2);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "GO!";
        GoAudio.Play();
        CountDown.SetActive(true);

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }

}
