using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    Rigidbody2D RB;
    public float moveSpeed = 10f; // Speed for horizontal movement
    public float jumpForce = 15f; // Force applied for jumping

    public GroundCheck groundCheck;  // To check if the character is grounded
    public Animator animator; // Animator for handling character animations

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleJumping();
    }

    void HandleMovement()
    {
        float horizontalInput = 0f;

        // Use A and D keys for movement
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f; // Move right
        }
        else if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f; // Move left
        }

        Vector2 currentVelocity = RB.velocity;

        if (horizontalInput > 0)
        {
            // Move right
            RB.velocity = new Vector2(moveSpeed, currentVelocity.y);
            transform.localScale = new Vector3(5, 5, 100); // Face right
            animator.SetInteger("IsMoving", 2); // Set moving right animation
        }
        else if (horizontalInput < 0)
        {
            // Move left
            RB.velocity = new Vector2(-moveSpeed, currentVelocity.y);
            transform.localScale = new Vector3(5, 5, 5); // Face left
            animator.SetInteger("IsMoving", 1); // Set moving left animation
        }
        else
        {
            // No movement
            RB.velocity = new Vector2(0, currentVelocity.y);
            animator.SetInteger("IsMoving", 0); // Set idle animation
        }
    }

    void HandleJumping()
    {
        // Use Backspace for jumping
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.Grounded)
        {
            // Apply jump force
            RB.velocity = new Vector2(RB.velocity.x, jumpForce);
            animator.SetTrigger("Jump"); // Play jump animation
        }

        // Update grounded animation state
        animator.SetBool("IsJumping", !groundCheck.Grounded);
    }
}
