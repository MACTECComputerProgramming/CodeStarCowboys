﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static float highScore = 00f;
    public static float scoreValue = 0f;
    Text score;


    // Start is called before the first frame update

    private void Start()
    {
        score = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score: " + scoreValue;
    }
}