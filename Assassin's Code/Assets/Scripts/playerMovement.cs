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
        changePlayerLook(transform.rotation.ToEulerAngles().z);
    }

    private bool CheckPos()
    {
        return true; //checks for walls etc before moving, to be added in future
    }

    public void changePlayerLook(float z)
    {
        z = Mathf.RoundToInt(z);
        if (z == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinLeftSide;
        }
        else if (z == -2)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinRightSide;
        }
        else if (z == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = assassinBehind;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = assassin;
        }
    }

}