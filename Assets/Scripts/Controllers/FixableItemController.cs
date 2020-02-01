using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixableItemController : MonoBehaviour {
    private Vector2 initialPos;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked = false;

    public static float rotationSpeed = 50.5f;

    // Init
    void Start () {
        initialPos = transform.position;
    }

    void Update() {
        if(Input.GetKey(KeyCode.Q)) {
            transform.Rotate( Vector3.forward * rotationSpeed * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.E)) {
            transform.Rotate( -Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseDown () {
        if (!locked) {
            deltaX = Camera.main.ScreenToWorldPoint (Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint (Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag () {
        if (!locked) {
            mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            transform.position = new Vector2 (mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }


}