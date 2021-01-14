using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALSColorSwitch : MonoBehaviour
{
    public GameObject alsLight;
    public List<Color> lightColors;
    public List<GameObject> myTriggerobjs;
    public GameObject currentTrigObj;
    public GameObject lastTrigObj;
    public Light currentLight;
    public Color myLightColor;
    public float delay = 0f;
    public int triggerPress = 0;
    public bool glassesOn = false;
   
    
    private void Start()
    {
        currentLight = GetComponent<Light>();
        currentLight.enabled = false;
        
    }
    
    public void ChangeLight()
    {
        currentLight.enabled = true;
        StartCoroutine(LightChange());
        triggerPress += 1;
        if (triggerPress > lightColors.Count)
        {
            triggerPress = 0;
        }
    }

    public void TurnOffLight()
    {
        currentLight.enabled = false;
        triggerPress = 0;
    }

    public void CheckGlassesTrue()
    {
        glassesOn = true;
    }
    
    public void CheckGlassesFalse()
    {
        glassesOn = false;
    }

    IEnumerator LightChange()
    {
        //int i = 0;
        
        if(currentLight.enabled == true)
        {
            myLightColor = lightColors[triggerPress];
            currentTrigObj = myTriggerobjs[triggerPress];
            if (glassesOn)
            {
                currentTrigObj.SetActive(true);
            }
            //currentTrigObj.SetActive(true);
            alsLight.GetComponent<Light>().color = myLightColor;
            Debug.Log("On trigger press"+ triggerPress + "active trigger is " + currentTrigObj.name);
            //Debug.Log("On trigger press"+ triggerPress + "the light is now " + currentLight.color + "my light color is " + myLightColor);
            
            if (triggerPress - 1 >= 0 )
            {
                lastTrigObj = myTriggerobjs[triggerPress - 1];
                lastTrigObj.SetActive(false);
            }
        }
        
        yield return new WaitForSeconds(delay);
        
        
    }
}
