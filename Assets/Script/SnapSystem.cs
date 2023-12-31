using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapSystem : MonoBehaviour
{

    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public DragDrop dragDrop;
    Vector3 mousePosition;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }


    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-3.6f, 10f), 0, Random.Range(12f, 0f));
    }

    //private void OnMouseDown()
    //{
    //    dragDrop.dragDrop = gameObject;
    //    mousePosition = Input.mousePosition - GetMousePos();
    //}

  

    private void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = ray.GetPoint(17.1f);
    }

// Update is called once per frame
void Update()
    {
        if (Vector3.Distance(a: transform.position, b: RightPosition) < 0.5f) 
        {
            if (Selected)
            {
                transform.position = RightPosition;
                InRightPosition = true;
            }
            
        }
    }
}
