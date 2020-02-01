using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMove : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;

    bool hammer = false;
    bool tongs = true;

    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        /*sprite1 = Resources.Load<Sprite>("Tongs Cursor_0");
        sprite2 = Resources.Load<Sprite>("Hammer Cursor_0");*/
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
/*        if (spriteRenderer.sprite == null)
        { // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
        }*/
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;


        if (Input.GetMouseButtonDown(0))
        {
            ClickSelect();
            /*Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);*/
            /*            if (hit)
                        {
                            print(hit.transform.gameObject.tag);
                            isPicked = true;
                        }
                        else
                        {
                            isPicked = false;
                        }*/
        }

        /*        if(Input.GetAccelerationEvent(1))
                {
                    print("Motion Detected");
                }*/

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            print("Button Pressed!");
        }

    }

    //This method returns the game object that was clicked using Raycast 2D
    void ClickSelect()
    {
        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            Debug.Log("Selected Object: " + hit.transform.name);
            if (hit.transform.gameObject.name.Equals("HammerButton"))
            {
                HammerMode();
            }else if (hit.transform.gameObject.name.Equals("TongsButton"))
            {
                TongsMode();
            }
            //return hit.transform.gameObject;
        }
        //else return null;
    }

    public void HammerMode()
    {
        hammer = true;
        tongs = false;
        spriteRenderer.sprite = sprite1;
    }
    public void TongsMode()
    {
        hammer = false;
        tongs = true;
        spriteRenderer.sprite = sprite2;
    }
}
