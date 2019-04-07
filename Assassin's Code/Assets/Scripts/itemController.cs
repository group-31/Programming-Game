using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemController : MonoBehaviour
{
    public int currentCoins;
    public Text coinText;

    public bool keyOwned;
    public Text keyText;

    void Start()
    {
        currentCoins = 0;
        keyOwned = false;

        coinText.text = "coins = " + currentCoins + ";";

        keyText.text = "key = " + keyOwned + ";";

    }

    public void coinPickup()
    {
        currentCoins++;

        coinText.text = "coins = " + currentCoins + ";";
    }

    public void keyPickup()
    {
        keyOwned = true;

        keyText.text = "key = " + keyOwned + ";";
    }
}
