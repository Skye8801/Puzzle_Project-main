using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop2 : MonoBehaviour
{

    public GameObject dragAndDrop;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (hit.transform.GetComponent<SnapSystem>().InRightPosition)
                {
                    dragAndDrop = hit.transform.gameObject;
                    dragAndDrop.GetComponent<SnapSystem>().Selected = true;
                }
                
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            dragAndDrop.GetComponent<SnapSystem>().Selected = false;
            dragAndDrop = null;
            
        }

        if (dragAndDrop != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragAndDrop.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }

    private RaycastHit Raycast(Vector3 vector3, Vector3 zero)
    {
        throw new NotImplementedException();
    }
}
