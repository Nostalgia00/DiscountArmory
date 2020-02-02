using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TemperatureGaugeController : MonoBehaviour {
    public float increment;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Slider sliderBar = GetComponent<Slider>();
        if (Input.GetKeyDown (KeyCode.Space)) {
            sliderBar.value += increment;
        } else if (sliderBar.value >= 0.0f) {
            float decayRate = 8*(sliderBar.value/100);
            sliderBar.value -= (decayRate * Time.deltaTime);
        }
        //sliderBar.color = Color.Lerp(Color.white, Color.red, slider.value / 20);
    }
}//sliderimage.color = Color.Lerp(Color.red, Color.green, slider.value / 20);