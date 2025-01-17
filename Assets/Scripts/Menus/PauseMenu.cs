using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu;

    void Start()
    {
        if (Pausemenu == null)
        {
            Debug.LogError("Pausemenu GameObject is not assigned!");
            return;
        }

        Pausemenu.SetActive(false);
        Time.timeScale = 1f; // Ensure time scale is normal at start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        if (Pausemenu != null)
        {
            Pausemenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeGame()
    {
        if (Pausemenu != null)
        {
            Pausemenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu"); // Replace with the correct scene name
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
