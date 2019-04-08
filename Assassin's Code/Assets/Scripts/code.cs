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
        for (int i = 0; i < list.Count; i++)
        {
            stringText += list[i] + "\n";
            displayText += displayList[i] + "\n";
        }
        if (list.Count == 0) { stringText = "Code goes here..."; displayText = stringText; }
        text.text = displayText;
    }

    public void Add(string n)
    {
        list.Add(n);
        if (n[0] == 'M')
        {
            int pos = + 2;
            string temp = "";
            while (n[pos] != ')')
            {
                temp += n[pos];
                pos++;
            }
            int val = Mathf.Abs(System.Convert.ToInt32(temp));
            temp = "";
            if (val > 1)
            {
                temp += ("for(int i = 0; i < " + val + "; i++)\n{\n    ");
            }
            if (n[2] != '-') temp += ("player.moveForward();");
            else temp += ("player.moveBack();");
            if (val > 1)
            {
                temp += ("\n}");
            }
            displayList.Add(temp);
        }
        else if (n[0] == 'T')
        {
            if(n == "T(180)") displayList.Add("player.turnAround();");
            else if (n[2] != '-') displayList.Add("player.turnRight();");
            else displayList.Add("player.turnLeft();");
        }
        else if (n[0] == 'W')
        {
            int pos = +2;
            string temp = "";
            while (n[pos] != ')')
            {
                temp += n[pos];
                pos++;
            }
            int val = Mathf.Abs(System.Convert.ToInt32(temp));
            temp = "";
            if (val > 1)
            {
                temp += ("for(int i = 0; i < " + val + "; i++)\n{\n    ");
            }
            temp += "player.wait();";
            if (val > 1)
            {
                temp += ("\n}");
            }
            displayList.Add(temp);
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
