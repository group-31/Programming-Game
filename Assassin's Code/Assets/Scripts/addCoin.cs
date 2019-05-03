using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCoin : MonoBehaviour
{
    public itemController coinCtrl;
    public score score;
    public int n;

    void Start()
    {
        coinCtrl = FindObjectOfType<itemController>();
        score = FindObjectOfType<score>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            coinCtrl.coinPickup();
            Destroy(gameObject);
            score.Score(n);
        }
    }
}