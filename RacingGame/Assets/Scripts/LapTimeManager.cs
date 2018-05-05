using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount;
	public static int SecondCount;
	public static float MilisecondCount;
	public static string MilisecondDisplay;

	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilisecondBox;

	void Update () {
		MilisecondCount += Time.deltaTime * 10;		
		MilisecondDisplay = MilisecondCount.ToString ("F0");
		MilisecondBox.GetComponent<Text> ().text = "" + MilisecondDisplay;

		if (MilisecondCount >= 10) {
			MilisecondCount = 0;
			SecondCount++;
		}	

		if (SecondCount <= 9) {
			SecondBox.GetComponent<Text> ().text = "0" + SecondCount + ".";
		} else {
			SecondBox.GetComponent<Text> ().text = "" + SecondCount + ".";
		}

		if (SecondCount >= 60) {
			SecondCount = 0;
			MinuteCount++;		
		}

		if (MinuteCount <= 9) {
			MinuteBox.GetComponent<Text> ().text = "0" + MinuteCount + ":";
		} else {
			MinuteBox.GetComponent<Text> ().text = "" + MinuteCount + ":";
		}
	}
}
