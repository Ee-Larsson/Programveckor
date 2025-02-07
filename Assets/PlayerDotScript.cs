using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDotScript : MonoBehaviour
{
    Rigidbody2D RB;
    bool WorL = false;

    public GameObject Line;
    public GameObject WinningSpot;

    public TreeScript TreeCode;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector2(10, 0);
        TreeCode = FindObjectOfType<TreeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        WinOrLose();
    }

    void WinOrLose()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (WorL == false)
            {
            } else if (WorL == true)
            {
                Destroy(TreeCode.WinningSpotClone);
                Destroy(TreeCode.LineClone);
                Destroy(gameObject);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        WorL = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        WorL = false;
    }
}
