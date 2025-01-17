using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemintoinventory : MonoBehaviour
{
    public bool isPlayerNear = false;
    public GameObject item;
    public Vector2 tpLocation;
    public bool inInventory = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerNear == true && Input.GetKeyUp(KeyCode.E))
        {
            item.SetActive(false);
            item.transform.position = tpLocation;
            inInventory = true;
        }
        if(FindObjectOfType<Inventory>().isInventoryOpen == true && inInventory == true)
        {
            item.SetActive(true);
        }
        if (FindObjectOfType<Inventory>().isInventoryOpen == false && inInventory == true)
        {
            item.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNear = true;
    }

}
