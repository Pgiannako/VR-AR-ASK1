using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableROT : MonoBehaviour
{

    private Vector3 currentEulerAngles;
    // Start is called before the first frame update
    void Start()
    {
        //currentEulerAngles = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        currentEulerAngles = transform.localEulerAngles;
        currentEulerAngles[1] = 0;
        transform.eulerAngles = currentEulerAngles;
    }
}
