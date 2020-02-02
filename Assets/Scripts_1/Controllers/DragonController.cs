using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class DragonController : MonoBehaviour {

    public float increment, holdTime, currentHoldTime;
    public Image flameFill;

    void Start () {
        currentHoldTime = holdTime;
    }

    // Update is called once per frame
    void Update () {
        flameFill = GetComponent<Image> ();
        if(Input.GetKeyDown(KeyCode.Return) ) {
           // flameFill.fillAmount -= 0.15f;

        }
        if (Input.GetKeyDown (KeyCode.Space) && flameFill.fillAmount <= 1.0f) {
            flameFill.fillAmount += increment;
            if (flameFill.fillAmount <= 0.5f) {
                currentHoldTime = holdTime;

            }

        } else if (flameFill.fillAmount >= 0.95f && currentHoldTime > 0f) {
            currentHoldTime -= Time.deltaTime;
            if (currentHoldTime < 0f) {
                currentHoldTime = 0f;
            }
        } else if (flameFill.fillAmount >= 0.0f) {
            float decayRate = 0.05f;
            flameFill.fillAmount -= decayRate * Time.deltaTime;

        }
    }
}