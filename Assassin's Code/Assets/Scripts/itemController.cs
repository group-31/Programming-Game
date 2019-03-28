using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public int currentCoins;
    public bool keyOwned;

    // Start is called before the first frame update
    void Start()
    {
        currentCoins = 0;
        keyOwned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coinPickup()
    {
        currentCoins++;
        
    }

    public void keyPickup()
    {
        keyOwned = true;
    }
}
