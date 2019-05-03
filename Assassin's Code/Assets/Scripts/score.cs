using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int scoreInt = 0;
    Text text;
    int lineNo;
    int runNo;

    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Score: 0";
    }

    public void Score(int amount)
    {
        scoreInt += amount;
        text.text = "Score: " + scoreInt;
    }
}