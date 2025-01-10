using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithAxe : MonoBehaviour
{
    bool isplayernearby = false;
    public GameObject PickupItem;

    
    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isplayernearby == true)
        {
            print("Spelaren plocka upp yxan");  
            gameObject.SetActive(false);
            //PickupItem.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Spelare är i närheten");
        isplayernearby = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isplayernearby = false;
        PickupItem.SetActive(false);
    }
}

