using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;
    public Transform transform;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "canPowder")
        {
            PaintWithPowder(); 
        }
        
    }

    public void PaintWithPowder()
    {
        Instantiate(powder, transform.position, transform.rotation);
        Debug.Log("powdering");
    }
}
