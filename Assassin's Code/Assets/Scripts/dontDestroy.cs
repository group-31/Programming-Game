using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //Ensures object isn't destroyed between levels
    }

}