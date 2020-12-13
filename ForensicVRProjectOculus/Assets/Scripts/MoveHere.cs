using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHere : MonoBehaviour
{
    public Transform transform;
    public GameObject objToMove;

    public void MoveIt()
    {
        objToMove.transform.position = transform.position;
        objToMove.transform.rotation= transform.rotation;
    }
}
