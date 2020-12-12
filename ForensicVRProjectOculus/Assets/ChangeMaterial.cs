using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material rightMaterial;
    public Material otherMaterial;
    public GameObject prefab;

    private void Awake()
    {
        prefab.GetComponent<Renderer>().material = rightMaterial;
    }

    public void ChangeColor()
    {
        prefab.GetComponent<Renderer>().material = otherMaterial;
    }
}
