using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{

    private bool mouseDown = false;
    private Vector2 startMousePos;
    private Vector2 startPos;


    public void OnMouseDown()
    {
        mouseDown = true;
        //transform.position = Input.mousePosition;
        //startMousePos = Input.mousePosition;
    }

    public void OnMouseUp()
    {
        mouseDown = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (mouseDown)
        {
            /*Vector2 currentPos = Input.mousePosition;
            Vector2 diff = currentPos - startMousePos;
            Vector2 pos = startPos + diff;
            transform.position = pos;*/
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Input.mousePosition;
            pos.z = 0;
            transform.position = pos;
        }
    }
}
