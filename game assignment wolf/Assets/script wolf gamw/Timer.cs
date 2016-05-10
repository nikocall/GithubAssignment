﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Collections;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private float maxTime = 60f;
 

    // Use this for initialization
    void Start()
    {

        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {


        float timeleft = maxTime - (Time.time - startTime);

        string minutes = ((int)timeleft / 60).ToString();
        float seconds = Mathf.Ceil(timeleft % 60);
         
        timerText.text = minutes + ":" + seconds;

        if (timeleft <= 0f)  
        {
            SceneManager.LoadScene("gameovertimeout");
        }
                
    }

    public void ExtendTime (float t)
    {
        startTime += t;
    }
   
}

