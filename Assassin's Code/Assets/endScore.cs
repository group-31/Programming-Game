using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
    int scoreInt = 0;
    Text text;
    int lineNo;
    int runNo;
    public score score;

    void Start()
    {
        score = FindObjectOfType<score>();
        text = GetComponent<Text>();
        text.text = "Score: 0";
    }

    void Update()
    {
        text.text = "Score: " + score.scoreInt;
    }
}