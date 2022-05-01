using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultConditions : MonoBehaviour
{
    private bool gameEnd;

    public void WinCondition()
    {
        if (!gameEnd)
        {
            Debug.Log("win");
            gameEnd = true;
        }
    }

    public void LoseCondition()
    {
        if (!gameEnd)
        {
            Debug.Log("lose");
            gameEnd = true;
        }
        
    }
}
