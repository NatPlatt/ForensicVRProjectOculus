using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTag : MonoBehaviour
{
    public string tagName;
    private GameObject myObj;
    public bool isTriggered = false;
    public bool isThisRight = false;
    public UnityEvent checkItEvent;
    public UnityEvent doTheThingEvent;
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;


    private void Start()
    {
        //myObj = gameObject.GetComponent<GameObject>();
        //myObj.tag = GetComponent<GameObject>().tag;
    }

    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
       // tagName = myObj.tag;
        if (other.CompareTag(tagName))
        {
            triggerEnterEvent.Invoke();
            
        }

        if (other.CompareTag(tagName) && isThisRight)
        {
            DoTheThing();
        }
        
        //Debug.Log(gameObject.name +" triggered by "+ other.tag);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagName) && isThisRight && isTriggered)
        {
            triggerExitEvent.Invoke();
        }
        
    }

    public void CheckIt()
    {
        isThisRight = true;
        if (isTriggered && isThisRight)
        {
            checkItEvent.Invoke();
        }
    }

    public void DoTheThing()
    {
        doTheThingEvent.Invoke();
    }
}
