using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Name: Rivera, Gustavo
 * Date: 04/06/2025
 * Last Updated: 04/06/2025
 * Descripton: Allows for the end screen buttons to function with the play button and quit button.
 * Allows the Player to go between scenes or quit the game
 */

public class EndScreen : MonoBehaviour
{
    /// <summary>
    /// Calls the function to load the main game 
    /// scene when the play button is pressed
    /// </summary>
    public void PlayButtonPressed(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    /// <summary>
    /// Calls the function to quit the game 
    /// when the quit button is pressed
    /// </summary>
    public void QuitButtonPressed()
    {
        print("Quit Game");
        Application.Quit();
    }
}
