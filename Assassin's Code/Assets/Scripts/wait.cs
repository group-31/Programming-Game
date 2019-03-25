using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wait : MonoBehaviour {

    public GameObject player;
    public GameObject c;
    public playerMovement pM;
    public code code;
    public InputField i;
    public int n;

	// Use this for initialization
	void Start ()
    {
        pM = player.GetComponent<playerMovement>();
        code = c.GetComponent<code>();
        n = 1;
	}

    public void Time()
    {
        n = int.Parse(i.text);
    }

    // Update is called once per frame
    public void Wait()
    {
        code.Add("W(" + n + ")");
	}

}
