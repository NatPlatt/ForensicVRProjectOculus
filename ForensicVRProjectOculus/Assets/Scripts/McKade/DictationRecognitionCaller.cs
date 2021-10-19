using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DictationRecognitionCaller : MonoBehaviour
{

    private bool isRunning;
    private string[] words;
    private List<string> listofwords;
    private string stringtoCheck, currentState;
    public TextMeshProUGUI prompt, hint, newPrintResult;
    private bool recognizedPhrase;
    private float incorrectCount;
    public float NumTries;


    public UnityEvent onSleep;
    public string ResultAfterText = "";

    private void Awake()
    {
        hint.text = "";
        incorrectCount = 0;
        listofwords = new List<string>();
        recognizedPhrase = false;
        stringtoCheck = "";
    }

    public void ToggleListen()
    {
        if (isRunning)
        {
            Stop();
        }
        else
        {
            Call();
        }
    }

    public void Call()
    {
        Debug.Log("Call: " + !isRunning);
        if (!isRunning)
        {
            //NEED TO ENABLE THIS AGAIN AFTER I GET THE DICTATION OBJECT FROM MCKADE
            //DictationObject.StartListening();
            isRunning = true;
            //StartCoroutine(running());
        }
    }
    public void StartListening()
    {

        Call();
    }

    public void Stop()
    {
        if (isRunning)
        {
            isRunning = false;
            //DictationObject.StopListening();
            prompt.text = "";
        }
    }

    /*public IEnumerator running()
    {
        while (isRunning)
        {
            if (DictationObject.state == "Result" && stringtoCheck != DictationObject.text && currentState != "Result")
            {
                Debug.Log("Result");
                currentState = "Result";
                prompt.text = "";
                stringtoCheck = DictationObject.text;

                newPrintResult.text = $"{(DictationObject.text)}";
                prompt.text = "";
            }
            else if (DictationObject.state == "Sleeping")
            {
                prompt.text = "";
                Stop();
                if (currentState != "Sleeping")
                    onSleep.Invoke();
                if (DictationObject.state == "Sleeping")
                {
                    prompt.text = "";
                    currentState = "Sleeping";
                }
                else
                {
                    prompt.text = DictationObject.state;
                    currentState = DictationObject.state;
                }
            }
            else if (DictationObject.state == "Thinking")
            {
                currentState = "Thinking";
                prompt.text = DictationObject.state;
            }
            else if (DictationObject.state == "Listening")
            {
                currentState = "Listening";
                prompt.text = DictationObject.state;
            }
            yield return new WaitForFixedUpdate();
        }
    }*/
}
