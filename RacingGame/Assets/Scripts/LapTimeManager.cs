using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount1;
	public static int SecondCount1;
	public static float MilisecondCount1;
	public static string MilisecondDisplay1;

	public GameObject MinuteBox1;
	public GameObject SecondBox1;
	public GameObject MilisecondBox1;

    public static int MinuteCount2;
    public static int SecondCount2;
    public static float MilisecondCount2;
    public static string MilisecondDisplay2;

    public GameObject MinuteBox2;
    public GameObject SecondBox2;
    public GameObject MilisecondBox2;

    void Update () {
        //Player One
		MilisecondCount1 += Time.deltaTime * 10;		
		MilisecondDisplay1 = MilisecondCount1.ToString ("F0");
		MilisecondBox1.GetComponent<Text> ().text = "" + MilisecondDisplay1;

		if (MilisecondCount1 >= 10) {
			MilisecondCount1 = 0;
			SecondCount1++;
		}	

		if (SecondCount1 <= 9) {
			SecondBox1.GetComponent<Text> ().text = "0" + SecondCount1 + ".";
		} else {
			SecondBox1.GetComponent<Text> ().text = "" + SecondCount1 + ".";
		}

		if (SecondCount1 >= 60) {
			SecondCount1 = 0;
			MinuteCount1++;		
		}

		if (MinuteCount1 <= 9) {
			MinuteBox1.GetComponent<Text> ().text = "0" + MinuteCount1 + ":";
		} else {
			MinuteBox1.GetComponent<Text> ().text = "" + MinuteCount1 + ":";
		}

        //Player Two
        MilisecondCount2 += Time.deltaTime * 10;
        MilisecondDisplay2 = MilisecondCount2.ToString("F0");
        MilisecondBox2.GetComponent<Text>().text = "" + MilisecondDisplay2;

        if (MilisecondCount2 >= 10)
        {
            MilisecondCount2 = 0;
            SecondCount2++;
        }

        if (SecondCount2 <= 9)
        {
            SecondBox2.GetComponent<Text>().text = "0" + SecondCount2 + ".";
        }
        else
        {
            SecondBox2.GetComponent<Text>().text = "" + SecondCount2 + ".";
        }

        if (SecondCount2 >= 60)
        {
            SecondCount2 = 0;
            MinuteCount2++;
        }

        if (MinuteCount2 <= 9)
        {
            MinuteBox2.GetComponent<Text>().text = "0" + MinuteCount2 + ":";
        }
        else
        {
            MinuteBox2.GetComponent<Text>().text = "" + MinuteCount2 + ":";
        }
    }
}
