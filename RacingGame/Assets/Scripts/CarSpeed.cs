using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour {

    public Rigidbody car1;

    public Rigidbody car2;

    public Text speedDisplay1;

    private int speed1;

    public Text speedDisplay2;

    private int speed2;

    // Update is called once per frame
    void FixedUpdate () {
        speed1 = (int)(car1.velocity.magnitude * 2.7);
        speedDisplay1.text = speed1.ToString();

        speed2 = (int)(car2.velocity.magnitude * 2.7);
        speedDisplay2.text = speed2.ToString();
    }
}
