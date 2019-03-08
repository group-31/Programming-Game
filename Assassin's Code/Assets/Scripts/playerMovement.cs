using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    void Start()
    {
        PlayerMove(3);
        PlayerTurn(90);
        PlayerMove(3);
    }

    void Update()
    {
        
    }

    public void PlayerMove(int n)
    {
        StartCoroutine(Move(n));
    }

    public void PlayerTurn(int n)
    {
        StartCoroutine(Turn(n));
    }

    public IEnumerator Move(int n)
    {
        for (int i = 0; i < n; i++)
        {
            yield return new WaitForSeconds(0.5f);
            transform.position += transform.up;
        }
    }

    public IEnumerator Turn(int n)
    {
        yield return new WaitForSeconds(0.5f);
        transform.Rotate(0,0,-n);
    }

}