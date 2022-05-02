using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public ResultConditions resultScript;
    
    void Start()
    {
        resultScript.Initialise();
    }

    void OnTriggerEnter (Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            
            resultScript.WinCondition();
        }
        
    }

}
