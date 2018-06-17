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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Headlights"))
        {
            headlightsEnabled = !headlightsEnabled;
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
