using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    void Start()
    {

    }

    public void Move(int n)
    {
        for (int i = 0; i < Mathf.Abs(n); i++)
        {
            if(CheckPos() && n > 0) transform.position += transform.up;
            if(CheckPos() && n < 0) transform.position -= transform.up;
        }
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
    }

    public void Wait(int n)
    {
        return; //fix soon
    }

    private bool CheckPos()
    {
        return true; //checks for walls etc before moving, to be added in future
    }

}