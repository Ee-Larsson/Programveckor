using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            ToggleVisibility();
        }
    }
    public void ToggleVisibility()
    {
        if (inventory != null)
        {
            inventory.SetActive(!inventory.activeSelf);
        }
    }
}
