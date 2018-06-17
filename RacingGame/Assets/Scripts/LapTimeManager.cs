using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa odpowiadajaca za pomiar czasu okrazen
/// </summary>
public class LapTimeManager : MonoBehaviour
{

    /// <summary>
    /// Licznik minut gracza nr 1
    /// </summary>
	public static int MinuteCount1;
    /// <summary>
    /// Licznik sekund gracza nr 1
    /// </summary>
    public static int SecondCount1;
    /// <summary>
    /// Licznik milisekund gracza nr 1
    /// </summary>
    public static float MilisecondCount1;
    /// <summary>
    /// Tekst do wyswietlenia milisekund gracza nr 1
    /// </summary>
    public static string MilisecondDisplay1;

    /// <summary>
    /// Pole wyswietlajace minuty gracza nr 1
    /// </summary>
    public GameObject MinuteBox1;
    /// <summary>
    /// Pole wyswietlajace sekundy gracza nr 1
    /// </summary>
    public GameObject SecondBox1;
    /// <summary>
    /// Pole wyswietlajace milisekundy gracza nr 1
    /// </summary>
    public GameObject MilisecondBox1;

    /// <summary>
    /// Licznik minut gracza nr 2
    /// </summary>
    public static int MinuteCount2;
    /// <summary>
    /// Licznik sekund gracza nr 2
    /// </summary>
    public static int SecondCount2;
    /// <summary>
    /// Licznik milisekund gracza nr 2
    /// </summary>
    public static float MilisecondCount2;
    /// <summary>
    /// Tekst do wyswietlenia milisekund gracza nr 2
    /// </summary>
    public static string MilisecondDisplay2;

    /// <summary>
    /// Pole wyswietlajace minuty gracza nr 2
    /// </summary>
    public GameObject MinuteBox2;
    /// <summary>
    /// Pole wyswietlajace sekundy gracza nr 2
    /// </summary>
    public GameObject SecondBox2;
    /// <summary>
    /// Pole wyswietlajace milisekundy gracza nr 2
    /// </summary>
    public GameObject MilisecondBox2;

    void Update()
    {
        //Player One
        MilisecondCount1 += Time.deltaTime * 10;
        MilisecondDisplay1 = MilisecondCount1.ToString("F0");
        MilisecondBox1.GetComponent<Text>().text = "" + MilisecondDisplay1;

        if (MilisecondCount1 >= 10)
        {
            MilisecondCount1 = 0;
            SecondCount1++;
        }

        if (SecondCount1 <= 9)
        {
            SecondBox1.GetComponent<Text>().text = "0" + SecondCount1 + ".";
        }
        else
        {
            SecondBox1.GetComponent<Text>().text = "" + SecondCount1 + ".";
        }

        if (SecondCount1 >= 60)
        {
            SecondCount1 = 0;
            MinuteCount1++;
        }

        if (MinuteCount1 <= 9)
        {
            MinuteBox1.GetComponent<Text>().text = "0" + MinuteCount1 + ":";
        }
        else
        {
            MinuteBox1.GetComponent<Text>().text = "" + MinuteCount1 + ":";
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
