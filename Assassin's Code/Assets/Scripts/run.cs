using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class run : MonoBehaviour
{
    public playerMovement pM;
    public GameObject player;
    public enemy enemyPlayer;
    public GameObject enemyPlayer2;
    public code c;
    public GameObject C;
    public Button go;
    public Button clear;
    public Button delete;
    public bool running = false;
    public GameObject space;
    public mashSpace m;
    public GameObject hide;
    public enemy[] enemies;

    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemies = FindObjectsOfType<enemy>();
        pM = player.GetComponent<playerMovement>();
        c = C.GetComponent<code>();
        go.onClick.AddListener(() => Click());
        m = space.GetComponent<mashSpace>();
    }

    public void Update()
    {
        if (running == false)
        {
            go.interactable = true;
            clear.interactable = true;
            delete.interactable = true;
            hide.SetActive(false);
        }
        else
        {
            go.interactable = false;
            clear.interactable = false;
            delete.interactable = false;
            hide.SetActive(true);
        }
    }

    public void Click()
    {
        if (running == false && c.list.Count > 0)
        {
            StartCoroutine(Execute(c.stringText));
            space.SetActive(true);
            m.MashSpace();
        }
    }

    public IEnumerator Execute(string s)
    {
        running = true;
        int pos = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == 'M')
            {
                pos = i + 2;
                string temp = "";
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                for (int j = 0; j < Mathf.Abs(System.Convert.ToInt32(temp)); j++)
                {
                    while (!Input.GetKeyDown(KeyCode.Space)) yield return null;

                    pM.Move(System.Convert.ToInt32(temp));
                    for (int k = 0; k < enemies.Length; k++)
                    {
                        enemies[k].enemyMove();
                    }
                    while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
                }
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
                while (!Input.GetKeyDown(KeyCode.Space)) yield return null;

                pM.Turn(System.Convert.ToInt32(temp));
                for (int k = 0; k < enemies.Length; k++)
                {
                    enemies[k].enemyMove();
                }
                while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
            }
            else if (c == 'W')
            {
                pos = i + 2;
                string temp = "";
                while (s[pos] != ')')
                {
                    temp += s[pos];
                    pos++;
                }
                for (int j = 0; j < Mathf.Abs(System.Convert.ToInt32(temp)); j++)
                {
                    while (!Input.GetKeyDown(KeyCode.Space)) yield return null;
                    for (int k = 0; k < enemies.Length; k++)
                    {
                        enemies[k].enemyMove();
                    }
                    while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
                }
            }
            while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
        }
        c.Clear();
        running = false;
    }
}
