﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Allows us to use scene loading function
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string sceneToLoad;

    public void StartGame()
    {
        //Reset the score
        PlayerPrefs.DeleteKey("Score");

        //Load first level
        SceneManager.LoadScene(sceneToLoad);
    }

}