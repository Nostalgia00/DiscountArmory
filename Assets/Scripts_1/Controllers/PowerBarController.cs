using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBarController : MonoBehaviour {
    static float t = 0.0f;
    public GameObject dragonObj;
    public float sweetSpotMin, sweetSpotMax;
    private Image dragonImage;

    private bool locked;

    private Slider powerBar;
    // Start is called before the first frame update
    void Start () {
        locked = true;
        powerBar = GetComponent<Slider> ();
        dragonImage = dragonObj.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Return) && locked && dragonImage.fillAmount >= 0.75f) {
            locked = !locked;
        }
        else if(dragonImage.fillAmount <=0f && !locked) {
            t=0;
            powerBar.value=0;
            locked = !locked;
        }
        else if (Input.GetKeyDown (KeyCode.Return) && dragonImage.fillAmount > 0f) {
            if(powerBar.value >=sweetSpotMin && powerBar.value <= sweetSpotMax) {
                Debug.Log("BING - GOOD");
            } else {
                Debug.Log("BONG - BAD");
            }
        }
        
        if (!locked) {
            t += Time.deltaTime;
            powerBar.value = Mathf.Abs(Mathf.Sin (t));
        }

    }
}