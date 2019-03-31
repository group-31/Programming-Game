using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTrack : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(3,0, -10);
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
