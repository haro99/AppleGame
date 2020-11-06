﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {
    public GameObject leftbutton;
    public GameObject rightbutton;
    public GameObject result;
    public Basket basket;
    public Apple apple;
    public Text timerText;
    public Scoreprint scoreprint;
    public Score score;
    float timer;
    int seconds;
	// Use this for initialization
	void Start () {
        timer = 30f;	
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        seconds = (int)timer;
        if (seconds > 0)
        {
            timerText.text = seconds.ToString();
        }
        else
        {
            timerText.text = "0";
            basket.timeout();
            apple.timeout();
            leftbutton.SetActive(false);
            rightbutton.SetActive(false);
            scoreprint.Scoreadd(score.Scorethrow());
            result.SetActive(true);

        }
    }
}
