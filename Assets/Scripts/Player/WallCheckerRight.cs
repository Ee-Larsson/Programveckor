using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheckerRight : MonoBehaviour
{
    public bool TouchWallRight = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TouchWallRight = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        TouchWallRight = false;
    }
}
