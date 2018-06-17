using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Klasa wyboru samochodu
/// </summary>
public class CarChoice : MonoBehaviour
{
    /// <summary>
    /// Czerwona karoseria
    /// </summary>
    public GameObject RedBody;
    /// <summary>
    /// Niebieska karoseria
    /// </summary>
    public GameObject BlueBody;
    //1 = RED
    //2 = BLUE
    /// <summary>
    /// Wybrany kolor karoserii (1 - czerwony, 2 - niebieski)
    /// </summary>
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        switch (CarImport)
        {
            case 1:
                RedBody.SetActive(true);
                break;
            case 2:
                BlueBody.SetActive(true);
                break;
        }
    }
}
