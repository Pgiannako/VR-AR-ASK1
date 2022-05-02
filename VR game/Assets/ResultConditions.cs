using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine(reset());
        }        
    }

    IEnumerator reset()
    {
        yield return new WaitForSecondsRealtime(3);  // wait 3 sec
        SceneManager.LoadScene("biliard table");
    }
}
