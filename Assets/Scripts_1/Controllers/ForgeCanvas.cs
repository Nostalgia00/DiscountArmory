﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ForgeCanvas : MonoBehaviour
{
    void HandleOnClick() {
        SceneManager.LoadScene ("anvil", LoadSceneMode.Single);

    }

}
