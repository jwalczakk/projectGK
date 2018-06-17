using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa odpowiadajaca za pomiar czasu w wyscigach od punktu A do B
/// </summary>
public class SprintTimeManager : MonoBehaviour {
    /// <summary>
    /// Licznik minut
    /// </summary>
    public static int MinuteCount;
    /// <summary>
    /// Licznik sekund
    /// </summary>
    public static int SecondCount;
    /// <summary>
    /// Licznik milisekund
    /// </summary>
    public static float MilisecondCount;
    /// <summary>
    /// Tekst do wyswietlenia milisekund
    /// </summary>
    public static string MilisecondDisplay;

    /// <summary>
    /// Pole wyswietlajace minuty
    /// </summary>
    public GameObject MinuteBox;
    /// <summary>
    /// Pole wyswietlajace sekundy
    /// </summary>
    public GameObject SecondBox;
    /// <summary>
    /// Pole wyswietlajace milisekundy
    /// </summary>
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
