using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHeadlights : MonoBehaviour
{

    public GameObject leftHeadlight;

    public GameObject rightHeadlight;

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

    IEnumerator ChangeMode()
    {
        yield return new WaitForSeconds(0.01f);
        leftHeadlight.SetActive(headlightsEnabled);
        rightHeadlight.SetActive(headlightsEnabled);
    }
}
