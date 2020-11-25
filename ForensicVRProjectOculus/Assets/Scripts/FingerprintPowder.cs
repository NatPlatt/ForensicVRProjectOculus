using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintPowder : MonoBehaviour
{
    public GameObject fingerprint;
    public GameObject powderBrush;
    public float colorRender;
    public float delay = 0f;
    public float touchNum = 0.1f;
    public Color powderColor;
    public void Start()
    { 
        fingerprint.GetComponent<Renderer>().material.color = powderColor;
        Debug.Log("powder color is " + powderColor);
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(PowderIt());
    }
   
    IEnumerator PowderIt()
    {
        touchNum += 0.1f;
        if (powderBrush.gameObject.tag == "powderBrush" && touchNum <= 1)
        {
            fingerprint.GetComponent<Renderer>().material.color = new Color(0.142f, 0.142f,0.142f, touchNum);
            
            //Debug.Log("touch num is "+touchNum);
            //Debug.Log("alpha value is "+ colorRender);
            
            yield return new WaitForSeconds(delay);
        }
    }
}
