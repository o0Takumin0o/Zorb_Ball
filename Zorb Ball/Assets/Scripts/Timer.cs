﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    
    private float startTime;
    private bool finnish = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnish) return;

        float time = Time.time - startTime;
        //string minutes = ((int) time /60).ToString();
        string seconds = (time % 60).ToString("f1");


        timerText.text = "Timer :"  + seconds+"S";
        //timerText.text = "Timer :" + minutes + ":" + seconds;
        

    }
    public void Finnish()
    {
        finnish = true;
        //timerText.color = Color.yellow;
    }
}
