using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zoom : MonoBehaviour
{
 

    [SerializeField] private Camera cam;

    float zoom = 10f;
    

    void Update()
    {
        if (cam.orthographic)
        {
            cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoom;
        }
        else
        {
            cam.fieldOfView += Input.GetAxis("Mouse ScrollWheel") * zoom;
        }
    }
}
