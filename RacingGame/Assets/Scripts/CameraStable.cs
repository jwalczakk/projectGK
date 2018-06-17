using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Klasa zapewniajaca stabilnosc kamery wzgledem samochodu
/// </summary>
public class CameraStable : MonoBehaviour {

    /// <summary>
    /// Obiekt samochodu
    /// </summary>
	public GameObject TheCar;
    /// <summary>
    /// Wspolrzedna X samochodu
    /// </summary>
	public float CarX;
    /// <summary>
    /// Wspolrzedna Y samochodu
    /// </summary>
	public float CarY;
    /// <summary>
    /// Wspolrzedna Z samochodu
    /// </summary>
	public float CarZ;
    /// <summary>
    /// Stan wlaczenia stablizacji
    /// </summary>
    private static bool stabilizationEnabled = true;
	
	// Update is called once per frame
	void Update () {
        if (stabilizationEnabled)
        {
            CarX = TheCar.transform.eulerAngles.x;
            CarY = TheCar.transform.eulerAngles.y;
            CarZ = TheCar.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
	}

    /// <summary>
    /// Setter stanu stabilizacji kamery
    /// </summary>
    /// <param name="enabled">czy wlaczona</param>
    public static void SetStabilizationState(bool enabled)
    {
        stabilizationEnabled = enabled;
    }
}
