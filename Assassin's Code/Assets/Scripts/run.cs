using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class run : MonoBehaviour
{
    public playerMovement pM;
    public GameObject player;
    public code c;
    public GameObject C;
    public Button b;

    public void Start()
    {
        pM = player.GetComponent<playerMovement>();
        c = C.GetComponent<code>();
        b.onClick.AddListener(() => Click());
    }

    public void Click()
    {
        Execute(c.stringText);
    }

    public void Execute(string s) //FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX FIX
    {
        int pos = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == 'M')
            {
                pos = i;
                string temp = "";
                pos += 2;
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                pM.Move(System.Convert.ToInt32(temp));
            }
            if (c == 'T')
            {
                string temp = "";
                pos += 2;
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                pM.Turn(System.Convert.ToInt32(temp));
            }
        }
    }
}
