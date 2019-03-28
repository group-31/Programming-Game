using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addKey : MonoBehaviour
{
    public itemController keyCtrl;
    // Start is called before the first frame update
    void Start()
    {
        keyCtrl = FindObjectOfType<itemController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onCollision(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            keyCtrl.keyPickup();
            Destroy(gameObject);
        }
    }
}
