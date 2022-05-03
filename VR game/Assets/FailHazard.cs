using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailHazard : MonoBehaviour
{

    public ResultConditions resultScript;

    void Start()
    {
        resultScript.Initialise();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            resultScript.LoseCondition();
        }
    }
}
