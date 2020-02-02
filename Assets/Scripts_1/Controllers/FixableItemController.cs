using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixableItemController : MonoBehaviour {
    private Vector2 initialPos;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked = false;

    public static float rotationSpeed = 50.5f;

    private List<Joycon> joycons;

    // Values made available via Unity
    public float[] stick;
    public Vector3 gyro;
    public Vector3 accel;
    public int jc_ind = 0;
    public Quaternion orientation;

    // Init
    void Start () {
        initialPos = transform.position;
        gyro = new Vector3(0, 0, 0);
        accel = new Vector3(0, 0, 0);
        // get the public Joycon array attached to the JoyconManager in scene
        joycons = JoyconManager.Instance.j;
        if (joycons.Count < jc_ind + 1)
        {
            Destroy(gameObject);
        }
    }

    void Update () {
        if (Input.GetMouseButton(0)) {
            if (Input.GetKey (KeyCode.Q)) {
                transform.Rotate (Vector3.forward * rotationSpeed * Time.deltaTime);
            } else if (Input.GetKey (KeyCode.E)) {
                transform.Rotate (-Vector3.forward * rotationSpeed * Time.deltaTime);
            }
        }

        if (joycons.Count > 0)
        {
            Joycon j = joycons[jc_ind];
            // GetButtonDown checks if a button has been pressed (not held)
            if (j.GetButtonDown(Joycon.Button.PLUS))
            {
                Debug.Log("Plus pressed");
                // GetStick returns a 2-element vector with x/y joystick components
                //Debug.Log(string.Format("Stick x: {0:N} Stick y: {1:N}", j.GetStick()[0], j.GetStick()[1]));

                // Joycon has no magnetometer, so it cannot accurately determine its yaw value. Joycon.Recenter allows the user to reset the yaw value.
                j.Recenter();
            }
            // GetButtonDown checks if a button has been released


            if (j.GetButtonDown(Joycon.Button.DPAD_DOWN))
            {
                Debug.Log("Rumble");

                // Rumble for 200 milliseconds, with low frequency rumble at 160 Hz and high frequency rumble at 320 Hz. For more information check:
                // https://github.com/dekuNukem/Nintendo_Switch_Reverse_Engineering/blob/master/rumble_data_table.md

                j.SetRumble(160, 320, 0.6f, 200);

                // The last argument (time) in SetRumble is optional. Call it with three arguments to turn it on without telling it when to turn off.
                // (Useful for dynamically changing rumble values.)
                // Then call SetRumble(0,0,0) when you want to turn it off.
            }

            stick = j.GetStick();

            // Gyro values: x, y, z axis values (in radians per second)
            gyro = j.GetGyro();

            // Accel values:  x, y, z axis values (in Gs)
            accel = j.GetAccel();

            if (accel.magnitude > 3)
            {
                j.SetRumble(50, 50, 5.0f, 1000);
            }

            orientation = j.GetVector();
            /*if (j.GetButton(Joycon.Button.DPAD_UP))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }*/
            /*orientation.y = 0;
            orientation.x = 0;
            gameObject.transform.rotation = orientation;*/
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