using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;
    public GameObject tapePieceObj;
    
    public Rigidbody rb;
    public Transform transform;
    public Material newMaterial;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "canPowder")
        {
            PaintWithPowder();
            //tapePieceObj.GetComponent<Rigidbody>().useGravity = false;
            //tapePieceObj.transform.position = new Vector3();
            
        }
        
    }

    public void PaintWithPowder()
    {
        Instantiate(powder, transform.position, transform.rotation);
        Debug.Log("powdering");
    }

    public void MakeTapePiece()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(tapePieceObj, transform.position, transform.rotation);
            tapePieceObj.SetActive(true);
        }
    }

    public void ChangeTapeColor()
    {
        tapePieceObj.GetComponent<Renderer>().material = newMaterial;
    }
}
