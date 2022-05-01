using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public ResultConditions resultScript;

    private void OnTriggerEnter(Collider other)
    {
        resultScript.WinCondition();
    }

}
