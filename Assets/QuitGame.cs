using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void ExitGame()
    {
        Debug.LogError("Button pressed!");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
