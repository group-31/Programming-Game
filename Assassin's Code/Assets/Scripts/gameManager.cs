using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadScene(int x)
    {
        SceneManager.LoadScene(x); //Loads level specified by input
    }

}