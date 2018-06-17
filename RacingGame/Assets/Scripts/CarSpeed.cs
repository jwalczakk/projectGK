using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa odczytujaca szybkosc samochodow
/// </summary>
public class CarSpeed : MonoBehaviour {
    /// <summary>
    /// Samochod nr 1
    /// </summary>
    public Rigidbody car1;

    /// <summary>
    /// Samochod nr 2
    /// </summary>
    public Rigidbody car2;

    /// <summary>
    /// Panel wyswietlajacy szybkosc samochodu nr 1
    /// </summary>
    public Text speedDisplay1;

    /// <summary>
    /// Szybkosc samochodu nr 1
    /// </summary>
    private int speed1;

    /// <summary>
    /// Panel wyswietlajacy szybkosc samochodu nr 1
    /// </summary>
    public Text speedDisplay2;

    /// <summary>
    /// Szybkosc samochodu nr 2
    /// </summary>
    private int speed2;

    // Update is called once per frame
    void FixedUpdate () {
        speed1 = (int)(car1.velocity.magnitude * 2.7);
        speedDisplay1.text = speed1.ToString();

        speed2 = (int)(car2.velocity.magnitude * 2.7);
        speedDisplay2.text = speed2.ToString();
    }
}
