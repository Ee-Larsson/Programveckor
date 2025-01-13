using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class WPlayerMovement2D : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && FindObjectOfType<Pause>().pause == false)
        {
            rb.velocity += new Vector2(3, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(7, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && FindObjectOfType<Pause>().pause == false)
        {
            rb.velocity += new Vector2(-3, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity += new Vector2(-7, 0);
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && FindObjectOfType<Pause>().pause == false)
        {
            rb.velocity += new Vector2(0, 3);
        }
    }
}
