using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void OnClickOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnCLickQuit()
    {
        Application.Quit();
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
