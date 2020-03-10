using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class openingScript : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void GotoOpeningScene()
    {
        SceneManager.LoadScene("OpeningScene");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
