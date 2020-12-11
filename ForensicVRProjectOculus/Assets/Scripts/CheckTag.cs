using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTag : MonoBehaviour
{
    private string tagName;
    public GameObject myObj;
    public bool isTriggered = false;
    public UnityEvent myEvent;


    private void Start()
    {
        myObj = GetComponent<GameObject>();
        myObj.tag = GetComponent<GameObject>().tag;
    }

    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        tagName = myObj.tag;
        if (other.tag == tagName)
        {
            CheckIt();
        }
        Debug.Log(gameObject.name +" triggered by "+ GetComponent<Collider>());
    }

    public void CheckIt()
    {
        myEvent.Invoke();
    }
}
