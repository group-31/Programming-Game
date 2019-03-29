using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code : MonoBehaviour
{
    private Text text;
    public List<string> list, displayList;
    public string stringText, displayText;

    void Start()
    {
        text = GetComponent<Text>();
        list = new List<string>();
        displayList = new List<string>();
    }

    void Update()
    {
        stringText = "";
        displayText = "";
        for(int i = 0; i < list.Count; i++)
        {
            stringText += list[i] + "\n";
            displayText += displayList[i] + "\n";
        }
        if (list.Count == 0) stringText = "Code goes here...";
        text.text = displayText;
    }

    public void Add(string n)
    {
        list.Add(n);
        if (n[0] == 'M')
        {
            if(n[2] != '-') displayList.Add("Move Forward " + n.Substring(1) + " Spaces");
            else displayList.Add("Move Back " + n.Substring(1) + " Spaces");
        }
        else if (n[0] == 'T')
        {
            if(n == "T(180)") displayList.Add("Turn Around");
            else if (n[2] != '-') displayList.Add("Turn Right");
            else displayList.Add("Turn Left");
        }
        else if (n[0] == 'W')
        {
            displayList.Add("Wait " + n.Substring(1) + " Turns");
        }
    }

    public void Delete()
    {
        if (list.Count != 0)
        {
            list.RemoveAt(list.Count - 1);
            displayList.RemoveAt(list.Count);
        }
    }

    public void Clear()
    {
        list.Clear();
        displayList.Clear();
    }
}
