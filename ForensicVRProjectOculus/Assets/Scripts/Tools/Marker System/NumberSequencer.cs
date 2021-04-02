using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberSequencer : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro numbDisplay;

    [SerializeField]
    GameObject currentMarker;

    public GameObject artObject;

    public IntDataEviMarker numVal;

    float timer = 100;
    bool timerOn = false;

    private void Awake()
    {
        numbDisplay.text = $"{numVal.currentNum.ToString()}";
        Debug.Log($"{numbDisplay}");
        Debug.Log($"{numVal.currentNum.ToString()}");
    }

    private void Update()
    {
        if (timerOn)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            DoDelete();
        }
    }

    public void SetText()
    {
        numbDisplay.text = $"{numVal.currentNum.ToString()}";
        Debug.Log(numbDisplay);
        Debug.Log(numVal.currentNum.ToString());
    }
   
    public void SetInactive()
    {
        artObject.SetActive(false);
        timerOn = true;
    }

    public void DoDelete()
    {
        Destroy(currentMarker);
    }
}
