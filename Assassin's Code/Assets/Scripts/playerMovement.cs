using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    void Start()
    {
        /*Move(1);
        Turn(90);
        //Wait(2);
        StartCoroutine(Wait());
        Move(2);*/
        StartCoroutine(currentPlayerMovement());
    }

    IEnumerator currentPlayerMovement() {
        Move(1);
        Turn(90);
        //Wait(2);
        //StartCoroutine(Wait(3f));
        yield return new WaitForSeconds(2f);
        //Wait(2f);
        Move(2);
        yield return new WaitForSeconds(1f);
    }

    void Update()
    {
        
    }

    public void Move(int n)
    {
        transform.position -= transform.up * n;
    }

    public void Turn(int n)
    {
        transform.Rotate(0,0,-n);
    }
    
    IEnumerator Wait(float n)
    {

        yield return new WaitForSeconds(n);

    }

}