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

    private List<Joycon> joycons;

    DragonController dragCon;

    // Values made available via Unity
    Joycon j;

    public float[] stick;
    public Vector3 gyro;
    public Vector3 accel;
    public int jc_ind = 0;
    public Quaternion orientation;

    // Start is called before the first frame update
    void Start () {
        dragCon = GameObject.Find("DragonIndicator_Flame").GetComponent<DragonController>();

        locked = true;
        powerBar = GetComponent<Slider> ();
        dragonImage = dragonObj.GetComponent<Image>();

        gyro = new Vector3(0, 0, 0);
        accel = new Vector3(0, 0, 0);
        // get the public Joycon array attached to the JoyconManager in scene
        joycons = JoyconManager.Instance.j;   
        j = joycons[jc_ind];
        if (joycons.Count < jc_ind + 1)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

        stick = j.GetStick();
        gyro = j.GetGyro();
        accel = j.GetAccel();
        if (FixableItemController.locked)
        {
            if ((Input.GetKeyDown(KeyCode.Return) || accel.magnitude > 3) && locked && dragonImage.fillAmount >= 0.75f)
            {
                locked = !locked;
                dragCon.flameFill.fillAmount -= 0.01f;
            }
            else if (dragonImage.fillAmount <= 0f && !locked)
            {
                t = 0;
                powerBar.value = 0;
                locked = !locked;
            }
            else if ((Input.GetKeyDown(KeyCode.Return) || accel.magnitude > 3) && dragonImage.fillAmount > 0f)
            {
                dragCon.flameFill.fillAmount -= 0.01f;

                j.SetRumble(50, 50, 5.0f, 1000);
                if (powerBar.value >= sweetSpotMin && powerBar.value <= sweetSpotMax)
                {
                    Debug.Log("BING - GOOD");
                    GameController.overallGameScore += 1;
                    Debug.Log("Score: " + GameController.overallGameScore);
                }
                else
                {
                    Debug.Log("BONG - BAD");
                }
            }

            if (!locked)
            {
                t += Time.deltaTime;
                powerBar.value = Mathf.Abs(Mathf.Sin(t));
            }
        }

    }
}