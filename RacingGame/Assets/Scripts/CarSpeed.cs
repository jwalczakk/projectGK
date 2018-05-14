using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour {

    public Rigidbody car;

    public Text speedDisplay;

    private int speed;
	
	// Update is called once per frame
	void FixedUpdate () {
        speed = (int)(car.velocity.magnitude * 2.7);
        speedDisplay.text = speed.ToString();
	}
}
