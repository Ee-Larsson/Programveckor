using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            RB.velocity = new Vector2(10, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.velocity = new Vector2(-10, 0);
        }


    }

   
}
