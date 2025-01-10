using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{
    float timer;
    public float startTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            FindObjectOfType<WPlayerMovement>().isCutsceneActive = false;
        }
        else if(timer > 0)
        {
            timer -= Time.deltaTime;
            print(timer);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("något gick in");
        transform.position = new Vector2(500, 0);
        FindObjectOfType<WPlayerMovement>().isCutsceneActive = true;
        timer = startTime;


    }
}
