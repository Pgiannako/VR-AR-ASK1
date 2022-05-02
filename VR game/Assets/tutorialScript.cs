using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.y < -20.0f)
        {
            Debug.Log("next scene");
        }
    }
}
