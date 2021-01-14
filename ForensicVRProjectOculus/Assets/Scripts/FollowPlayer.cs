using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    void FixedUpdate()
    {
        transform.position = target.position + Vector3.up * offset.y
                                             + target.right * offset.x
                                             + target.forward * offset.y;
        transform.rotation = target.rotation;
    }
}
