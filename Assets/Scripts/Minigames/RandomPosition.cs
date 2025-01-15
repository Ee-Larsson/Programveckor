using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float RandomX = Random.Range(-10, 10);

        transform.position = new Vector2(RandomX, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
