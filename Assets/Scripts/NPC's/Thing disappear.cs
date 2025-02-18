using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thingdisappear : MonoBehaviour
{
    public bool isPlayerNear = false;
    public GameObject thingNPC;
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
            thingNPC.transform.position = new Vector2(500, 0);
        }
        if (currentTime <= 0 && isPlayerNear == false)
        {
            thingNPC.transform.localPosition = new Vector2(-22.45f, 2.19f);
        }
        else if (currentTime >= 0 )
        {
            currentTime -= Time.deltaTime;
            print(currentTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNear = true;
        print("player near");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentTime = startTime;
        isPlayerNear = false;
        print("player is gone");
    }

}
