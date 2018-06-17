using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Klasa sterujaca przednimi swiatlami samochodu
/// </summary>
public class CarHeadlights : MonoBehaviour
{
    /// <summary>
    /// Lewy reflektor
    /// </summary>
    public GameObject leftHeadlight;
    /// <summary>
    /// Prawy reflektor
    /// </summary>
    public GameObject rightHeadlight;
    /// <summary>
    /// Stan wlaczenia reflektorow
    /// </summary>
    private bool headlightsEnabled = false;
    /// <summary>
    /// Czy uzywac alternatywnych przyciskow (dla gracza nr 2)
    /// </summary>
    public bool UseAlternativeButtons;

    // Update is called once per frame
    void Update()
    {
        if (!UseAlternativeButtons)
        {
            if (Input.GetButtonDown("Headlights"))
            {
                headlightsEnabled = !headlightsEnabled;
            }
        }
        else
        {
            if (Input.GetButtonDown("HeadlightsAlt"))
            {
                headlightsEnabled = !headlightsEnabled;
            }
        }

        StartCoroutine(ChangeMode());
    }

    /// <summary>
    /// Zmiana trybu swiecenia
    /// </summary>
    /// <returns></returns>
    IEnumerator ChangeMode()
    {
        yield return new WaitForSeconds(0.01f);
        leftHeadlight.SetActive(headlightsEnabled);
        rightHeadlight.SetActive(headlightsEnabled);
    }
}
