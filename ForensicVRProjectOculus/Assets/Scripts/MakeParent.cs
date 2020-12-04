using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeParent : MonoBehaviour
{
    public GameObject childObj;
    public GameObject parentObj;

    
    public void SetParent()
    {
        //make childObj child of parent object and move it
        childObj.transform.SetParent(parentObj.transform);
        childObj.transform.localPosition = parentObj.transform.localPosition;
        childObj.transform.localRotation = parentObj.transform.localRotation;
        childObj.transform.localScale = parentObj.transform.localScale;
        
        Debug.Log("Objects parent: " + childObj.transform.parent.name);
        
        //Check if the new parent has a parent object
        if (parentObj.transform.parent != null)
        {
            Debug.Log("Parents parent: "+ childObj.transform.parent.parent.name);
        }
    }

    public void DetachParent()
    {
        transform.SetParent(null);
    }
}
