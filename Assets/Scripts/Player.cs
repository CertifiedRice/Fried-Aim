using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public float Score;
    public float timeRemaining = 5f;
    
    // UI Variables 
    public Text ScoreText;
    public Text TimeText;
    public GameObject EndGameUi;
    
    void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            EndGameUi.SetActive(true);
            Pause();
        }

        TimeText.text = "Time Left: " + timeRemaining;
        ScoreText.text = "Score: " + Score;
    }

    public void AddScore()
    {
        Score++;
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }
}
