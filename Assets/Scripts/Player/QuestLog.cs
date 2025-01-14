using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLog : MonoBehaviour
{
    public GameObject questLog;
    // Start is called before the first frame update
    void Start()
    {
        questLog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            ToggleVisibility();
        }
    }

    public void ToggleVisibility()
    {
        if (questLog != null)
        {
            questLog.SetActive(!questLog.activeSelf);   
        }
    }
}
