using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turn : MonoBehaviour {

    public GameObject player;
    public playerMovement pM;
    public Dropdown d;
    public int n = -90;

	// Use this for initialization
	void Start ()
    {
        pM = player.GetComponent<playerMovement>();
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
        pM.Turn(n);
	}
}
