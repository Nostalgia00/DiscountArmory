using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticItemController : MonoBehaviour {

    public GameObject draggableItem;
    public Collider2D draggableCollider;
    float distance;
    void Start() {
        draggableCollider = GameObject.Find("DraggableSword").GetComponent<Collider2D>();
    }

    void Update() {
        distance = GetComponents<Collider2D>()[1].Distance(draggableCollider).distance;
        if(distance >= 0.01f) {
            Debug.Log("Red");
        } else if(distance < 0.01f && distance >=-0.0005f) {
            Debug.Log("Amber");
        } else {
            Debug.Log("Green");
        }

        Debug.Log("Distance= " + distance);
    }
    void OnCollisionEnter2D (Collision2D coll) {
    }
}