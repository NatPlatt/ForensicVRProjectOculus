using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;
    private GameObject tapePieceObj;
    public List<GameObject> objectsList;
    public MeshRenderer meshRender;
    public Transform transform;
    public Material newMaterial;
    public int triggerPressNum =0;
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

    public void MakeTapePiece()
    {
        if (triggerPressNum <= objectsList.Count)
        {
            for (int i = 0; i < 1; i++)
            {
                objectsList[triggerPressNum].transform.position = transform.position;
                objectsList[triggerPressNum].transform.rotation = transform.rotation;
                objectsList[triggerPressNum].SetActive(true);
                tapePieceObj = objectsList[triggerPressNum];
            }
        }
    }

    public void BringItHere()
    {
        if (triggerPressNum <= objectsList.Count)
        {
            for (int i = 0; i < 1; i++)
            {
                objectsList[triggerPressNum].transform.position = transform.position;
                objectsList[triggerPressNum].transform.rotation = transform.rotation;
            }
        }
    }
    public void MakeVisible()
    {
       
        if (triggerPressNum <= objectsList.Count)
        {
            for (int i = 0; i < 1; i++)
            {
                objectsList[triggerPressNum].transform.position = transform.position;
                objectsList[triggerPressNum].transform.rotation = transform.rotation;
                meshRender = objectsList[triggerPressNum].GetComponent<MeshRenderer>();
                meshRender.enabled = true;
            }
        }
    }

    public void AddOne()
    {
        triggerPressNum += 1;
    }

    public void ChangeTapeColor()
    {
        tapePieceObj.GetComponent<Renderer>().material = newMaterial;
    }
}
