using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPlayerMovement : MonoBehaviour
{
    public bool isCutsceneActive = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody2D>();
        isCutsceneActive = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 0);
        if (isCutsceneActive == false && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            rb.velocity += new Vector2(3, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(7, 0);
            }
        }
        if (isCutsceneActive == false && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            rb.velocity += new Vector2(-3, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(-7, 0);
            }
        }
        if (isCutsceneActive == false && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            rb.velocity += new Vector2(0, 3);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(0, 7);
            }
        }
        if (isCutsceneActive == false && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            rb.velocity += new Vector2(0, -3);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(0, -7);
            }
        }
    }
}
