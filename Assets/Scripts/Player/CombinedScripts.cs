using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    Rigidbody2D RB;
    public float moveSpeed = 10f;
    public float jumpForce = 15f;

    public float jumpCooldown = 0.5f; // Cooldown in seconds
    private float lastJumpTime = 0f; // Tracks time of last jump
    public float groundCheckThreshold = 0.1f; // Threshold for detecting "grounded" state

    public Animator animator;

    public LeftChecker Left;
    public RightChecker Right;


    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        if (animator == null)
            Debug.LogError("Animator is not assigned!");
    }

    void Update()
    {
        HandleMovement();
        HandleJumping();
    }

    void HandleMovement()
    {
        float horizontalInput = 0f;

        if (Input.GetKey(KeyCode.D) && Left.TouchLeft == false)
        {
            horizontalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.A) && Right.TouchRight == false)
        {
            horizontalInput = -1f;
        }

        Vector2 currentVelocity = RB.velocity;

        if (horizontalInput > 0)
        {
            RB.velocity = new Vector2(moveSpeed, currentVelocity.y);
            animator.SetInteger("IsMoving", 2);
        }
        else if (horizontalInput < 0)
        {
            RB.velocity = new Vector2(-moveSpeed, currentVelocity.y);
            animator.SetInteger("IsMoving", 1);
        }
        else
        {
            RB.velocity = new Vector2(0, currentVelocity.y);
            animator.SetInteger("IsMoving", 0);
        }
    }

    void HandleJumping()
    {
        // Use vertical velocity to check if the character is grounded
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && IsGrounded() && Time.time - lastJumpTime >= jumpCooldown)
        {
            Debug.Log("Jumping!");
            RB.velocity = new Vector2(RB.velocity.x, jumpForce);
            animator.SetTrigger("Jump");
            lastJumpTime = Time.time; // Reset jump timer
        }

        // Update animation state
        animator.SetBool("IsJumping", !IsGrounded());
    }

    // Grounded state based on vertical velocity
    bool IsGrounded()
    {
        return Mathf.Abs(RB.velocity.y) < groundCheckThreshold;
    }
}
