using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material rightMaterial;
    public Material otherMaterial;
    public GameObject prefab1;
    public GameObject prefab2;

    private void Awake()
    {
        prefab1.GetComponent<Renderer>().material = rightMaterial;
        
    }

    public void ChangeColor()
    {
        prefab1.GetComponent<Renderer>().material = otherMaterial;
        
    }
}
