using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public float vol = 1;
    public Slider volSlider;

    void Update()
    {
        if(volSlider == null)
        {
            volSlider = (Slider)FindObjectOfType(typeof(Slider));
        }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex); //Loads level
    }

    public void ChangeVolume()
    {
        vol = volSlider.value;
    }

}