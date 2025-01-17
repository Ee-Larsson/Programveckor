using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Thingdisappear : MonoBehaviour
{
    bool isPlayerNear = false;
    GameObject thingNPC;
    public float startTime = 1;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNear == true)
        {
            thingNPC.SetActive(false);
        }
        if (currentTime <= 0)
        {
            thingNPC.SetActive(true);
        }
        else 
        if (currentTime >= 0)
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNear = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentTime = startTime;
    }

}
