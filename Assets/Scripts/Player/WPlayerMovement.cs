using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector2(2, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(7, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity += new Vector2(-2, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(-7, 0);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity += new Vector2(0, 2);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(0, 7);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity += new Vector2(0, -2);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(0, -7);
            }
        }
    }
}
