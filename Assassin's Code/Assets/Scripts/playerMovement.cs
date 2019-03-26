using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Sprite assassin, assassinBehind, assassinLeftSide, assassinRightSide;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.identity;
    }

    public void Move(int n)
    {
        if(CheckPos() && n > 0) transform.position += transform.up;
        if(CheckPos() && n < 0) transform.position -= transform.up;
        //this.GetComponent<SpriteRenderer>().sprite = assassin;
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
        //Debug.Log(Mathf.RoundToInt(transform.rotation.ToEulerAngles().z));
        changePlayerLook(transform.eulerAngles.z);
        Debug.Log(Mathf.RoundToInt(transform.eulerAngles.z));
    }

    private bool CheckPos()
    {
        return true; //checks for walls etc before moving, to be added in future
    }

    public void changePlayerLook(float n)
    {
        int z = Mathf.RoundToInt(n);
        if (z == 90)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinLeftSide;
            Debug.Log("left");
        }
        if (z == 270)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinRightSide;
            Debug.Log("right");
        }
        if (z == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinBehind;
            Debug.Log("up");
        }
        if (z == 180)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassin;
            Debug.Log("down");
        }
    }

}