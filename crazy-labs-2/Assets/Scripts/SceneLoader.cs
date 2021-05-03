﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadStartScreen ()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadEndScreen ()
    {
        SceneManager.LoadScene(2);
    }
}
