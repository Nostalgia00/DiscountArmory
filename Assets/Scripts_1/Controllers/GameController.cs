using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Game Controller should handle the following logic:
 * > Scene Transitions
 * > Game Score
 * > Link to a Sword Object, indicating fix status etc
 */
public class GameController : MonoBehaviour
{

    public static long overallGameScore = 0L;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static Scene GetCurrentScene()
    {
        return SceneManager.GetActiveScene();
    }

    public static void LoadScene(String sceneToLoad)
    {
        //get current scene
        //unload it
        //load new scene
        //load ui frame?
    }
}
