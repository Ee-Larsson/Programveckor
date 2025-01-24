using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDotScript : MonoBehaviour
{
    Rigidbody2D RB;
    bool WorL = false;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();


    }

    void WinOrLose()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (WorL == false)
            {
                print("miss");
            } else if (WorL == true)
            {
                print("success");
            }
        }
    }
    void Movement()
    {
        if (transform.position.x <= -8)
        {
            RB.velocity = new Vector2(10, 0);
        }
        else if (transform.position.x >= 8)
        {
            RB.velocity = new Vector2(-10, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WorL = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        WorL = false;
    }
}
