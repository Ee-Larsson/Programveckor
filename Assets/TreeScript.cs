using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public GameObject PlayerDot;
    public GameObject Line;
    public GameObject WinningSpot;

    public GameObject WinningSpotClone;
    public GameObject LineClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject PlayerDotClone = Instantiate(PlayerDot, new Vector2(1, -1), Quaternion.identity);
            WinningSpotClone = Instantiate(WinningSpot, new Vector2(1, -1), Quaternion.identity);
            LineClone = Instantiate(Line, new Vector2(1, -1), Quaternion.identity);
        }
    }
}
