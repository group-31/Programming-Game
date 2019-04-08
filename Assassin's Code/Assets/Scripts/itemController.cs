using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public int currentCoins;
    public bool keyOwned;

    void Start()
    {
        currentCoins = 0;
        keyOwned = false;
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
