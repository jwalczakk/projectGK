using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlueBody;
    //1 = RED
    //2 = BLUE
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
