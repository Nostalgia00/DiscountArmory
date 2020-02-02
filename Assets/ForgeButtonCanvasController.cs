using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ForgeButtonCanvasController : MonoBehaviour
{
    public void HandleOnClick() {
        SceneManager.LoadScene ("SwordScene", LoadSceneMode.Single);

    }

}
