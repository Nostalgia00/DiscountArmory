using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForgeButtonController : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    public void HandleOnClick () {
        SceneManager.LoadScene ("ForgeScene", LoadSceneMode.Single);

    }

    public void HandleOnClick_main () {
        SceneManager.LoadScene ("main", LoadSceneMode.Single);

    }

}