using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pause == false)
        {
            pauseMenu.SetActive(false);
        }else if (pause== true)
        {
            pauseMenu.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Escape) && pause == false)
        {
            pause = true;
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && pause == true)
        {
            pause = false;
        }
        if (Input.GetKeyUp(KeyCode.Backspace) && pause == true)
        {
            Application.Quit();
            print("the game has now closed");
        }
    }
}
