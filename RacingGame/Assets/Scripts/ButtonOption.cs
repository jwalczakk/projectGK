using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Klasa reprezentujaca wybor przycisku w menu glownym
/// </summary>
public class ButtonOption : MonoBehaviour {

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(3);
    //}
    /// <summary>
    /// Przejscie do ekranu rozpoczecia gry
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Przejscie do menu glownego
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Below here are track selection buttons
    /// <summary>
    /// Wybor trasy nr 1
    /// </summary>
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// Wybor trasy nr 2
    /// </summary>
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }

    /// <summary>
    /// Wybor trasy nr 3
    /// </summary>
    public void Track03()
    {
        SceneManager.LoadScene(4);
    }
}
