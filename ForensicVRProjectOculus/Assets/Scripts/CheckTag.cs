using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTag : MonoBehaviour
{
    public string tagName;
    public GameObject otherObj;
    public bool isTriggered;
    public UnityEvent myEvent;
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        CheckIt();
    }

    public void CheckIt()
    {
        if (otherObj.gameObject.CompareTag(tagName) && isTriggered == true)
        {
            myEvent.Invoke();
        }
    }
}
