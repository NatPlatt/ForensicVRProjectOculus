using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetTheBool : MonoBehaviour
{
    public bool myBool;
    public UnityEvent trueEvent;
    public UnityEvent falseEvent;
    
    public void SetToTrue()
    {
        myBool = true;
    }

    public void SetToFalse()
    {
        myBool = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        myBool = other.GetComponent<SetTheBool>().myBool;
    }

    public void RunTheCorrectEvent()
    {
        if (myBool == true)
        {
            trueEvent.Invoke();
        }

        if (myBool == false)
        {
            falseEvent.Invoke();
        }
    }
}
