using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerDispencer : MonoBehaviour
{
    public GameObject markerObj;
    public GameObject dispenseLoc;
    public IntDataEviMarker resetNum;

    private void Awake()
    {
        resetNum.ResetNum();
    }

    public void DispenceMarker()
    {
        Instantiate(markerObj, dispenseLoc.transform.position, dispenseLoc.transform.rotation);
    }
}
