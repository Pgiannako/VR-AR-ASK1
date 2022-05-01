using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{

    public ResultConditions resultScript;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10.0f)
        {
            resultScript.LoseCondition();
        }
    }
}
