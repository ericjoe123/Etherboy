﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    /*
     * COUNTDOWN FOR HOW LONG THE SPLASH SCREEN LASTS BEFORE FIRING THE MAIN MENU
     */
    private float waitTime = 0f;
    private float goalTime = 2f;
    
	void Update () {

       if (waitTime < goalTime)
        {
            waitTime += Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
	}
}