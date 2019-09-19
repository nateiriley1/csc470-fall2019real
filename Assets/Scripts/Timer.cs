﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text countdownText;
    float currentTime = 0f;
    float startingTime = 30f;
    // Start is called before the first frame update
    void Start()
    {

        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();

    }
}
