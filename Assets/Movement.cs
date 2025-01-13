using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D RB;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Anim.SetInteger("IsMoving", 0);
        RB.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            Anim.SetInteger("IsMoving", -2);
            RB.velocity = new Vector2(0, 4);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Anim.SetInteger("IsMoving", -1);
            RB.velocity = new Vector2(0, -4);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Anim.SetInteger("IsMoving", 1);
            RB.velocity = new Vector2(-4, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Anim.SetInteger("IsMoving", 2);
            RB.velocity = new Vector2(4, 0);
        }
    }
}
