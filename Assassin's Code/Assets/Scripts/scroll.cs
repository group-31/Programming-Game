using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour
{
    private Text text;
    public code code;
    public List<string> scrollList, displayScrollList;
    public string stringText, displayText;
    
    void Start()
    {
        text = GetComponent<Text>();
        scrollList = new List<string>();
        displayScrollList = new List<string>();
    }

    void Update()
    {
        stringText = "";
        displayText = "";
        for (int i = 0; i < scrollList.Count; i++)
        {
            stringText += scrollList[i] + "\n";
            displayText += displayScrollList[i] + "\n";
        }
        if (scrollList.Count == 0) stringText = "Empty...";
        text.text = displayText;
    }

    public void AddCode()
    {
        for (int i = 0; i < code.list.Count; i++)
        {
            scrollList.Add(code.list[i]);
            displayScrollList.Add(code.displayList[i]);
        }
    }
}
