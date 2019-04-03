using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Collider2D col;
    public GameObject tileSet;
    public bool forward;
    public GameObject manager;
    public gameManager gM;

    public Sprite assassin, assassinBehind, assassinLeftSide, assassinRightSide;

    void Start()
    {
        col = GetComponent<Collider2D>();
        transform.rotation = Quaternion.identity;
        manager = GameObject.Find("Game Manager");
        gM = manager.GetComponent<gameManager>();
    }

    public void Move(int n)
    {
        if (n > 0) { forward = true; transform.position += transform.up; }
        if (n < 0) { forward = false; transform.position -= transform.up; }
        //this.GetComponent<SpriteRenderer>().sprite = assassin;
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
        //Debug.Log(Mathf.RoundToInt(transform.rotation.ToEulerAngles().z));
        changePlayerLook(transform.eulerAngles.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Walls" || other.gameObject.name == "Door")
        {
            if (forward == true) transform.position -= transform.up;
            else transform.position += transform.up;
            //Debug.Log("Collision detected");
        }
        if (other.gameObject.name == "Exit")
        {
            gM.LoadNext();
        }
    }

    public void changePlayerLook(float n)
    {
        int z = Mathf.RoundToInt(n);
        if (z == 90)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinLeftSide;
        }
        if (z == 270)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinRightSide;
        }
        if (z == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinBehind;
        }
        if (z == 180)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassin;
        }
    }

}