using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EndGameUI : MonoBehaviour
{
    public Text timeText;

    public float TimeRemaining = 5;
    
    void Update()
    {
        if (TimeRemaining > 0)
        {
            TimeRemaining -= Time.deltaTime;
        }
        else
        {
            LoadMenu();
        }

        timeText.text = "Returning to menu in: " + TimeRemaining + " seconds";
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
