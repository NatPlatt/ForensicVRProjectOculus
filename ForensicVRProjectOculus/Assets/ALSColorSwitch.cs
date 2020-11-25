using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALSColorSwitch : MonoBehaviour
{

    public List<Light> lightColors;
    public Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = false;
    }

    public void ChangeLight()
    {
        int i = 0;
        foreach (var light in lightColors)
        {
            myLight.enabled = false;
            i++;
            myLight = lightColors[i];
            myLight.enabled = true;
        }

        

        if (i >= lightColors.Count)
        {
            i = 0;
        }
    }
}
