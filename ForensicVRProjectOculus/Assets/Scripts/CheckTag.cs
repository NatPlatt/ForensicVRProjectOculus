using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTag : MonoBehaviour
{
    public string tagName;
    public GameObject myObj;
    public bool isTriggered = false;
    public UnityEvent myEvent;
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;


    private void Start()
    {
        //myObj = GetComponent<ameObject>();
        //myObj.tag = GetComponent<GameObject>().tag;
    }

    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        tagName = myObj.tag;
        if (other.CompareTag(tagName))
        {
            triggerEnterEvent.Invoke();
        }
        Debug.Log(gameObject.name +" triggered by "+ other.tag);
    }

    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    /*public void CheckIt()
    {
        myEvent.Invoke();
    }*/
}
