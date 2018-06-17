using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Klasa odpowiadajaca za obrot kamery po ukonczeniu wyscigu
/// </summary>
public class FinishCamRotate : MonoBehaviour {

	void Update ()
    {
        transform.Rotate(0, 0.5f, 0, Space.World);
	}
}
