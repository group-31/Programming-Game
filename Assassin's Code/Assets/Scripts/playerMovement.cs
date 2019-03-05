using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    void Start()
    {
        Move(1);
        Turn(90);
        Wait(2);
        Move(2);
    }

    void Update()
    {
        
    }

    public void Move(int n)
    {
        transform.position += transform.up * n;
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
    }

    public void Wait(float n) //needs work
    {
        while (n > 0)
        {
            n -= Time.deltaTime;
            Debug.Log(".");
        }
        return;
    }

}