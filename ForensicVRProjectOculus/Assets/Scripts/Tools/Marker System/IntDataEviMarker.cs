using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class IntDataEviMarker : ScriptableObject
{
    public int currentNum;

    public void IncrementCount()
    {
        currentNum += 1;
    }

    public void DecreaseCount()
    {
        currentNum -= 1;
    }
    
    public void ResetNum()
    {
        currentNum = 0;
    }
}
