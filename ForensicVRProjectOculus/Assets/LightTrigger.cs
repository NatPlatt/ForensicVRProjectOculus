using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : ALSColorSwitch
{
    public List<GameObject> visibleByALS;
    public string colorActivate;
    private GameObject currentActiveObj;
    void Start()
    {
        for (int i = 0; i <= visibleByALS.Count; i++)
        {
            visibleByALS[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ALS" && visibleByALS.Contains(other.gameObject))
        {
            other.gameObject.SetActive(true);
        }
        //if (other.gameObject.tag == "ALS" && colorActivate == "UV" && lightColors[2]==myLightColor)
    }

    public void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
    }*/
}
