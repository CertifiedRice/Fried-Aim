using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public static Player Instance;

    public float Score;
    public float timeRemaining = 5f;
    
    // UI Variables 
    public Text ScoreText;
    public Text TimeText;
    public GameObject GameEnded;

    
    // Game Objects
    public GameObject player;
    
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
            GameEnded.SetActive(true);
            StartCoroutine(TeleportToMenu());
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

    IEnumerator TeleportToMenu()
    {
        // Debug.Log("Started Coroutine at timestamp : " + Time.time);

        yield return new WaitForSeconds(5);
        
        SceneManager.LoadScene("Menu");
    }
}
