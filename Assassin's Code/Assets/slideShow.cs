using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slideShow : MonoBehaviour
{
    public Slider s;
    Vector3 origin;
    public float x;

    void Start()
    {
        origin = transform.position;
    }

    void Update()
    {
        transform.Translate(-(s.value * x),0,0);
    }
}
