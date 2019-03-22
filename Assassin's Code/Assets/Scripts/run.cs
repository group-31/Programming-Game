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
    public Button go;
    public Button clear;
    public Button delete;
    private bool running = false;

    public void Start()
    {
        pM = player.GetComponent<playerMovement>();
        c = C.GetComponent<code>();
        go.onClick.AddListener(() => Click());
    }

    public void Update()
    {
        if (running == false)
        {
            go.interactable = true;
            clear.interactable = true;
            delete.interactable = true;
        }
        else
        {
            go.interactable = false;
            clear.interactable = false;
            delete.interactable = false;
        }
    }

    public void Click()
    {
        if(running == false) StartCoroutine(Execute(c.stringText));
    }

    public IEnumerator Execute(string s)
    {
        running = true;
        int pos = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == 'T' || c == 'M') while (!Input.GetKeyDown(KeyCode.Space)) yield return null;
            if (c == 'M')
            {
                pos = i + 2;
                string temp = "";
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                pM.Move(System.Convert.ToInt32(temp));
            }
            else if (c == 'T')
            {
                pos = i + 2;
                string temp = "";
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                pM.Turn(System.Convert.ToInt32(temp));
            }
            while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
        }
        running = false;
    }
}
