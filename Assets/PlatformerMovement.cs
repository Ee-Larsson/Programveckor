using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    Rigidbody2D RB;
    public GroundCheck script;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(0, 0);

        Movement();

        Jumping();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RB.velocity = new Vector2(10, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.velocity = new Vector2(-10, 0);
        }
    }

    void Jumping()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (script.Grounded == true)
            {
                print("odd");
                RB.velocity = new Vector2(0, 50);
            }
        }
    }
}
