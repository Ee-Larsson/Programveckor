using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaraCode : MonoBehaviour
{
    bool Sit = false;
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
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (Sit == false)
            {
                Sit = true;
            } else if (Sit == true)
            {
                Sit = false;
            }
        }
    }
}
