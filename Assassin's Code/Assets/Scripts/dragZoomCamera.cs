using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragZoomCamera : MonoBehaviour
{
    public float dragSpeed;
    private Vector3 dragOrigin;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
        {
            if (transform.position.z > - 20) transform.Translate(0, 0, -1);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
        {
            if (transform.position.z < 0) transform.Translate(0,0,1);
        }

        if (Input.GetMouseButtonDown(2))
        {
            transform.position = new Vector3(0, 0, -15);
        }

        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        transform.Translate(move, Space.World);
    }
}
