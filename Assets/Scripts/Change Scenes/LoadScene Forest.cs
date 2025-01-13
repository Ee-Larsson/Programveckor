using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneForest : MonoBehaviour
{
    bool isplayernearby = false;
    public int sceneToLoad = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isplayernearby == true)
        {
            print("Spelaren vill prata med NPC");
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Något är i närheten");
        isplayernearby = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isplayernearby = false;

    }

}
