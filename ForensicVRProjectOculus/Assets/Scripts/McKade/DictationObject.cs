
using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.Windows.Speech;

#if UNITY_EDITOR
[InitializeOnLoadAttribute]
#endif
public static class DictationObject
{
    static DictationRecognizer dictation;
    static bool dictationisRunning;
    public static string text, state;

    public enum DictationState
    {
        Listening,
        Thinking,
        Result,
        Sleeping,
        Stopped
    }

    public static DictationState dictationState;

    static DictationObject()
    {
#if UNITY_EDITOR
        EditorApplication.playModeStateChanged += LogPlayModeState;
#endif
        Initialize();
        dictationisRunning = false;
    }
#if UNITY_EDITOR
    private static void LogPlayModeState(PlayModeStateChange state)
    {

        //Debug.Log("Change State " + state);
        //EnteredEditMode & ExitingEditMode
        //EnteredPlayMode & ExitingPlayMode
        if (state.ToString() == "EnteredPlayMode")
        {
            Initialize();
        }
        else if (state.ToString() == "ExitingPlayMode")
        {
            //DisposeOf();
            StopListening();
        }
    }
#endif
    private static void dictation_Hypothesis(string text)
    {
        Debug.Log("Thinking");
        DictationObject.state = "Thinking";
        dictationState = DictationState.Thinking;
    }

    private static void dictation_Result(string text, ConfidenceLevel confidence)
    {
        Debug.Log(text + " confidence: " + confidence);
        DictationObject.text = text;
        DictationObject.state = "Result";
        dictationState = DictationState.Result;
    }

    private static void dictation_Complete(DictationCompletionCause cause)
    {
        if (cause != DictationCompletionCause.Complete)
        {
            Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", cause);
        }
        //StopListening();
        Stop();
        dictationisRunning = false;
        Debug.Log("Sleeping");
        DictationObject.state = "Sleeping";
        dictationState = DictationState.Sleeping;
    }

    private static void Initialize()
    {
        if (dictation != null)
            dictation.Dispose();
        dictation = new DictationRecognizer();
        dictation.DictationHypothesis += dictation_Hypothesis;
        dictation.DictationResult += dictation_Result;
        dictation.DictationComplete += dictation_Complete;
        dictationisRunning = false;
    }

    public static void StartListening()
    {
        if (!dictationisRunning)
        {
            if (dictation == null)
            {
                Initialize();
                Debug.Log("NULL");
            }
            dictationisRunning = true;
            DictationObject.state = "Listening";
            dictationState = DictationState.Listening;
            dictation.Start();
            Debug.Log("Start");
        }
        dictationisRunning = true;

    }

    public static void StopListening()
    {
        if (dictationisRunning)
        {
            if (dictation != null)
            {
                DictationObject.state = "";
                dictationState = DictationState.Stopped;
                dictation.Stop();
                dictation_Complete(DictationCompletionCause.Complete);
                //Debug.Log("Stop");
            }
            dictationisRunning = false;
        }
        dictationisRunning = false;
    }

    private static void Stop()
    {
        if (dictationisRunning)
        {
            if (dictation != null)
            {
                DictationObject.state = "";
                dictationState = DictationState.Stopped;
                dictation.Stop();
                Debug.Log("Stop");
            }
            dictationisRunning = false;
        }
        dictationisRunning = false;
    }

    private static void DisposeOf()
    {
        Debug.Log("Dispose");
        if (dictation != null)
        {
            dictation.Dispose();
        }
    }
}
