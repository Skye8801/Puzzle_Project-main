using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapSystem : MonoBehaviour
{

    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;


    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(x: Random.Range(2f, 14f), y: Random.Range(2.5f, -10f));
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
