using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTag : MonoBehaviour
{
    public string tagName;
    public GameObject otherObj;
    public bool isTriggered = false;
    public UnityEvent myEvent;
    

    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        CheckIt();
        Debug.Log("I am triggered by "+ GetComponent<Collider>());
    }

    public void CheckIt()
    {
        if (otherObj.gameObject.CompareTag(tagName) && isTriggered == true)
        {
            myEvent.Invoke();
        }
    }
}
