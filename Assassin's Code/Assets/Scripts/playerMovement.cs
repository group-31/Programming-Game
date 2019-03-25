using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.identity;
    }

    public void Move(int n)
    {
        if(CheckPos() && n > 0) transform.position += transform.up;
        if(CheckPos() && n < 0) transform.position -= transform.up;
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
    }

    private bool CheckPos()
    {
        return true; //checks for walls etc before moving, to be added in future
    }

}