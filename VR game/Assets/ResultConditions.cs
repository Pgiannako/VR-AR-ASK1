using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultConditions : MonoBehaviour
{
    private bool gameEnd;
    public GameObject winUI;
    public GameObject loseUI;


    public void Initialise()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
    }
    public void WinCondition()
    {
        if (!gameEnd)
        {
            winUI.SetActive(true);
            Debug.Log("win");
            gameEnd = true;
        }
    }

    public void LoseCondition()
    {
        if (!gameEnd)
        {
            loseUI.SetActive(true); 
            Debug.Log("lose");
            gameEnd = true;
        }
        
    }
}
