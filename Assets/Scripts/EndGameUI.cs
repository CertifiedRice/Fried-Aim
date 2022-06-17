using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class EndGameUI : MonoBehaviour
{
    public Button MenuReturn;
    
    void Update()
    {
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
