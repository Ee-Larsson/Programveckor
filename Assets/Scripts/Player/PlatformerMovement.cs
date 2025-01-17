using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement1 : MonoBehaviour
{
    Rigidbody2D RB;
    public int JumpPower;

    public GroundCheck script; //Used to get all of the variables needed from other scripts
 

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
                RB.velocity = new Vector2(RB.velocity.x, JumpPower);
            }
        }
    }
}
