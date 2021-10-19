using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterSequencer : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro letterDisplay;

    [SerializeField]
    GameObject currentMarker;

    public GameObject artObject;

    public LetterDataMarker letterVal;

    float timer = 100;
    bool timerOn = false;

    private void Awake()
    {
        letterDisplay.text = $"{letterVal.printString}";
        Debug.Log($"{letterDisplay}");
        Debug.Log($"{letterVal.printString.ToString()}");
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
        letterDisplay.text = $"{letterVal.printString.ToString()}";
        Debug.Log($"{letterDisplay}");
        Debug.Log($"{letterVal.printString.ToString()}");
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
