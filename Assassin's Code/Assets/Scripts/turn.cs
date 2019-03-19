using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turn : MonoBehaviour {

    public GameObject player;
    public GameObject c;
    public playerMovement pM;
    public code code;
    public Dropdown d;
    public int n;

	// Use this for initialization
	void Start ()
    {
        pM = player.GetComponent<playerMovement>();
        code = c.GetComponent<code>();
        n = -90;
	}

    public void Direction()
    {
        if (d.value == 0) n = -90;
        if (d.value == 1) n = 90;
        if (d.value == 2) n = 180;
    }

    // Update is called once per frame
    public void Turn()
    {
        code.Add("T(" + n + ")");
	}

}
