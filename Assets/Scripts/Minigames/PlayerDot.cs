using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDot : MonoBehaviour
{
    Rigidbody2D RB;
    static bool Win = false;

    bool ForS = false; //Used for winning and losing

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector2(-20, 0); // Dot movement
    }

    // Update is called once per frame
    void Update()
    {
        BackAndForwards();

        ButtonPress();
    }

    void BackAndForwards()
    {
        if (transform.position.x <= -8) // Used for dot moving right and left
        {
            RB.velocity = new Vector2(20, 0);
        }
        else if (transform.position.x >= 8)
        {
            RB.velocity = new Vector2(-20, 0);
        }
    }

    void ButtonPress()
    {
        if (Input.GetKeyUp(KeyCode.Space) && ForS == false)
        {
            print("try again");
        } else if (Input.GetKeyUp(KeyCode.Space) && ForS == true)
        {
            Win = true;
            SceneManager.LoadScene(10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // Both make it possible to win
    {
        ForS = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ForS = false;
    }
}

