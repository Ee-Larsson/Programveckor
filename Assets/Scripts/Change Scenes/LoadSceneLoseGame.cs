using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneLoseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isplayernearby = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isplayernearby == true)
        {
            print("Spelaren vill prata med NPC");
            SceneManager.LoadScene(12);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("N�got �r i n�rheten");
        isplayernearby = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isplayernearby = false;

    }
}
