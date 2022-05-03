using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showdeaths : MonoBehaviour
{

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Start()
    {
        text.text = $"You died {scoring.totalDeaths} times ";
    }

}
