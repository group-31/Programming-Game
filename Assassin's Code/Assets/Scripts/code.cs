using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code : MonoBehaviour
{
    private Text text;
    private List<string> list;
    public string stringText;

    void Start()
    {
        text = GetComponent<Text>();
        list = new List<string>();
    }

    void Update()
    {
        stringText = "";
        for(int i = 0; i < list.Count; i++)
        {
            stringText += list[i] + "\n";
        }
        if (list.Count == 0) stringText = "Code goes here...";
        text.text = stringText;
    }

    public void Add(string n)
    {
        list.Add(n);
    }

    public void Delete()
    {
        list.RemoveAt(list.Count-1);
    }

    public void Clear()
    {
        list.Clear();
    }
}
