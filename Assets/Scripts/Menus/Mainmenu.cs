using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 public void PlayGame()
    {
        SceneManager.LoadScene("Area 2 Village");
    }
 public void QuitGame()
    {
        Application.Quit();
    }
    public void Settings()
    {
        SceneManager.LoadScene("SettingMenu");

    }
}
