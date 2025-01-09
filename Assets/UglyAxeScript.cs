using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public string Axe;

    // Start is called before the first frame update
    public void interact()
    {
        Debug.Log("Interacted with " + Axe);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
