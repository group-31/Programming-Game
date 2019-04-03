using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCoin : MonoBehaviour
{
    public itemController coinCtrl;
    // Start is called before the first frame update
    void Start()
    {
        coinCtrl = FindObjectOfType<itemController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            coinCtrl.coinPickup();
            Destroy(gameObject);
        }
    }
}
