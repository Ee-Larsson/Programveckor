using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    bool isplayernearby = false;
    public GameObject diolog;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isplayernearby == true)
        {
            print("Spelaren vill plocka upp yxa");
            diolog.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Något är i närheten");
        isplayernearby = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isplayernearby = false;
        diolog.SetActive(false);
    }
}
