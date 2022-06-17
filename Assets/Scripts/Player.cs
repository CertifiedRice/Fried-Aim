using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public float Score;
    
    // UI Variables 
    public Text ScoreText;
    
    void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ScoreText.text = "Score: " + Score;
    }

    public void AddScore()
    {
        Score++;
    }
}
