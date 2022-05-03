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
            StartCoroutine(nextScene());
        }
    }

    public void LoseCondition()
    {
        if (!gameEnd)
        {
            loseUI.SetActive(true); 
            Debug.Log("lose");
            gameEnd = true;
            scoring.totalDeaths += 1;
            StartCoroutine(reset());
        }        
    }

    IEnumerator reset()
    {
        yield return new WaitForSecondsRealtime(3);  // wait 3 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSecondsRealtime(3);  // wait 3 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);  // TODO add a way to figure when we reach the last scene
    }
}
