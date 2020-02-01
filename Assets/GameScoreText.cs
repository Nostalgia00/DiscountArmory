using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScoreText : MonoBehaviour
{
    Text scoreCount;
 
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text = "Total Score: " + (GameController.overallGameScore).ToString();
        Debug.Log(GameController.overallGameScore);
    }
}
