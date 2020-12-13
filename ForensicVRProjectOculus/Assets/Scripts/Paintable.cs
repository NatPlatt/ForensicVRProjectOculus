using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;
    private GameObject tapePieceObj;
    public string activeTape;
    public List<GameObject> piecesOfTape;
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
        if (triggerPressNum <= piecesOfTape.Count)
        {
            for (int i = 0; i < 1; i++)
            {
                piecesOfTape[triggerPressNum].transform.position = transform.position;
                piecesOfTape[triggerPressNum].transform.rotation = transform.rotation;
                piecesOfTape[triggerPressNum].SetActive(true);
                activeTape = piecesOfTape[triggerPressNum].name;
                tapePieceObj = piecesOfTape[triggerPressNum];
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
