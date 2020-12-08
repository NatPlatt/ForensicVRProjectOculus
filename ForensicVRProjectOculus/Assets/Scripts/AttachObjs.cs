using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjs : MonoBehaviour
{
    public GameObject myObj;
    public Collider collider;
    public string myTag;

    private void Start()
    {
        myObj = GetComponent<GameObject>();
        collider = myObj.GetComponent<Collider>();
    }

    public void Attach()
    {
        if (myObj.tag == myTag && collider.isTrigger)
        {
            
        }
    }
}
