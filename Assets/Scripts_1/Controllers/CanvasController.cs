using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {
    public float aValue = 1;
    private CanvasGroup trans;
    void Start () {
        trans = GetComponent<CanvasGroup> ();
        trans.alpha = aValue;
    }
}