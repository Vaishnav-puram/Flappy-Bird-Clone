using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InBetweenPipeCollider : MonoBehaviour
{
    public LogicManager logicScript;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        if (logicScript != null)
        {
            Debug.Log("LogicManager found : " + logicScript.gameObject.name);
        }
        else
        {
            Debug.LogError("LogicManager not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // anything in this function will run whenever an object hits the trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("inside onTrigger()");
        logicScript.addScore();
    }
}
