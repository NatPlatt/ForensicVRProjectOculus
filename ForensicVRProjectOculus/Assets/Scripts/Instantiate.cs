using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 transform;

    public void InstantiateIt()
    {
        Instantiate(prefab, transform, Quaternion.identity);
    }
}
