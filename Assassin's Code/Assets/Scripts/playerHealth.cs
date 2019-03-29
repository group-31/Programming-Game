using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {

    public Sprite assassin;
    public GameObject spawn;

    public void Reset()
    {
        transform.position = spawn.transform.position;
        transform.eulerAngles = new Vector3(0, 0, 0);
        this.GetComponent<SpriteRenderer>().sprite = assassin;
    }
}
