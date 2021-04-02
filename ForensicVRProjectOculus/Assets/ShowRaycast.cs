using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRaycast : MonoBehaviour
{
    private LineRenderer showLine;
    private Vector3 offsetDis;

    public GameObject rayOrign;
    public bool canRaycast = false;
    public LayerMask canHit;
    public Transform endPoint;
    public Transform altEndPoint;

    private void Awake()
    {
        canRaycast = false;
        showLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (canRaycast)
        {
            RaycastHit hit;

            if(Physics.Raycast(transform.position, transform.forward, out hit, canHit))
            {
                if (hit.collider)
                {
                    Quaternion activePointRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                    endPoint.SetPositionAndRotation(hit.point, activePointRotation);
                    showLine.SetPosition(0, rayOrign.transform.position);
                    
                    showLine.SetPosition(1, endPoint.position);
                }
            }

            else
            {
                showLine.SetPosition(0, rayOrign.transform.position);

                showLine.SetPosition(1, altEndPoint.position);
            }
        }
    }

    public void canRaycastOff()
    {
        canRaycast = false;
        showLine.gameObject.SetActive(false);
    }

    public void canRaycastOn()
    {
        showLine.gameObject.SetActive(true);
        canRaycast = true;
    }
}
