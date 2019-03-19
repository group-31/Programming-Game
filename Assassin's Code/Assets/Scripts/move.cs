using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

    public GameObject player;
    public GameObject c;
    public playerMovement pM;
    public code code;
    public Dropdown d;
    public InputField i;
    public int n = 1;

	// Use this for initialization
	void Start ()
    {
        pM = player.GetComponent<playerMovement>();
        code = c.GetComponent<code>();
	}

    public void Sign()
    {
        if (d.value == 0 && n < 0) n = -n;
        if (d.value == 1 && n > 0) n = -n;
    }

    public void Distance()
    {
        n = int.Parse(i.text);
        Sign();
    }

    // Update is called once per frame
    public void Move()
    {
        code.Add("M(" + n + ")");
    }
}
