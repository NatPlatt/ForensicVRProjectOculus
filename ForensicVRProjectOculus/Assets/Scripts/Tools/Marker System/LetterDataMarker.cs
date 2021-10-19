using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class LetterDataMarker : ScriptableObject
{

    public List<string> lettersList;

    public string printString;
    public int currentLetterEquiv;


    public void Awake()
    {
        lettersList = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    }

    public void IncrementCount()
    {
        if (currentLetterEquiv < 26)
        {
            printString = lettersList[currentLetterEquiv];
            currentLetterEquiv += 1;
        }
        else
        {
            currentLetterEquiv = 0;
            printString = lettersList[currentLetterEquiv];
            currentLetterEquiv += 1;

        }

    }

    public void DecreaseCount()
    {
        currentLetterEquiv -= 1;
    }

    public void ResetNum()
    {
        currentLetterEquiv = 0;
        printString = lettersList[currentLetterEquiv];
    }
}

