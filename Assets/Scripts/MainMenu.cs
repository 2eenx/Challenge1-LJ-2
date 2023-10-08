using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Settings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void Play()
    {
        SceneManager.LoadScene("LoadingScreen");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Mods()
    {
        SceneManager.LoadScene("ModsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Game Closed");
    }
}
