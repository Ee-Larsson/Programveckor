using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    public bool isPlayerNearby = false;
    public GameObject textBox;
    public GameObject completedTextBox;
    public int playerItemCount = 0;
    private bool questStarted = false;
    void Start()
    {
        textBox.SetActive(false);
        completedTextBox.SetActive(false);
    }
    void Update()
    {
        if (isPlayerNearby == true)
        {
            if (questStarted)
            {
                completedTextBox.SetActive(true);
            }
            else
            {
                textBox.SetActive(true);
            }
        }
        if (isPlayerNearby == false)
        {
            completedTextBox.SetActive(false);
        }
        if (isPlayerNearby == true && Input.GetKeyDown(KeyCode.E))
        {
            if (!questStarted)
            {
                if (playerItemCount >= 5)
                {
                    playerItemCount -= 5;
                    Debug.Log("You had enough items! 5 items have been used. Remaining: " + playerItemCount);
                    questStarted = true;
                    Destroy(textBox);
                    completedTextBox.SetActive(true);
                }
                else
                {
                    Debug.Log("You don't have enough items! You need at least 5.");
                }           
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNearby = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        textBox.SetActive(false);
        completedTextBox.SetActive(false);
    }
}
