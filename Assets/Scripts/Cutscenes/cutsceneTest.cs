using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<WPlayerMovement>().isCutsceneActive == true)
        {
            transform.position = new Vector2(2, 2);
            Debug.Log("movement");
        }
    }
}
