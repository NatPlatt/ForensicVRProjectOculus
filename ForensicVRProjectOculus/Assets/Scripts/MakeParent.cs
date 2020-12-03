using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeParent : MonoBehaviour
{
    public GameObject childObj;

    public void SetParent(GameObject newParent)
    {
        //makes the newParent obj the parent of the childObj
        childObj.transform.parent = newParent.transform;
        
        Debug.Log("Objects parent: " + childObj.transform.parent.name);
        
        //Check if the new parent has a parent object
        if (newParent.transform.parent != null)
        {
            Debug.Log("Parents parent: "+ childObj.transform.parent.parent.name);
        }
    }

    public void DetachParent()
    {
        transform.parent = null;
    }
}
