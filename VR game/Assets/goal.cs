﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.name == "goal")
        {
            GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1);
            Destroy(gameObject);
        }
    }
}
