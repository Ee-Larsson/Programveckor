using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClaraCode : MonoBehaviour
{
    public Animator Anim;
    bool SittingVariable = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SittingVariable = true;
        Anim.SetBool("Sit", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SittingVariable = false;
        Anim.SetBool("Sit", false);
    }
}
