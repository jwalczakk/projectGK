using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa odpowiada za odliczanie sekund przed startem wyscigu
/// </summary>
public class Countdown : MonoBehaviour
{
    /// <summary>
    /// Pole wyswietlajace kolejne etapy odliczania
    /// </summary>
    public GameObject CountDown;
    /// <summary>
    /// Obiekt zliczajacy okrazenia
    /// </summary>
    public GameObject LapTimer;
    /// <summary>
    /// Obiekty odpowiadajace za sterowanie samochodami
    /// </summary>
    public GameObject[] CarControls;
    /// <summary>
    /// Pola, w ktorych wyswietla sie wymagana liczba okrazen do ukonczenia
    /// </summary>
    public GameObject[] LapRequirementBoxes;

    /// <summary>
    /// Wyzwalacz wzbudzany przy ukonczeniu okrazenia
    /// </summary>
    public GameObject LapCompleteTrigger;

    /// <summary>
    /// Dzwiek przygotowujacy do startu
    /// </summary>
    public AudioSource GetReady;
    /// <summary>
    /// Dzwiek startu
    /// </summary>
    public AudioSource GoAudio;

    void Start()
    {
        StartCoroutine(CountStart());
        if (LapRequirementBoxes != null)
            foreach (GameObject box in LapRequirementBoxes)
                box.GetComponent<Text>().text = string.Format("/ {0}", LapCompleteTrigger.GetComponent<LapComplete>().LapsRequirement);
    }

    /// <summary>
    /// Metoda rozpoczynajaca odliczanie
    /// </summary>
    /// <returns></returns>
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
        foreach (GameObject obj in CarControls)
            obj.SetActive(true);
    }

}
