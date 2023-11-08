using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Vector3 mousePosition;

    public GameObject dragDrop;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    //private void OnMouseDown()
    //{
    //    mousePosition = Input.mousePosition - GetMousePos();
    //}


    //private void OnMouseDrag()
    //{
    //    transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    //}

    //void Update()
    //{
       
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        dragDrop.GetComponent<SnapSystem>().Selected = false;
    //        dragDrop = null;
    //    }

    //    if (dragDrop != null)
    //    {
    //        Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        dragDrop.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
    //    }
    //}

    private RaycastHit Raycast(Vector3 vector3, Vector3 zero)
    {
        throw new NotImplementedException();
    }
}
