﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI text;

    public static int gemAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gemAmount.ToString();
        if (gemAmount > HighScore.highScore)
        {
            HighScore.highScore = gemAmount;
        }
    }
}