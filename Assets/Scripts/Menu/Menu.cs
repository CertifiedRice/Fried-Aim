using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject LevelsUI;
    public GameObject SettingsUI;

    public void PlayLevels()
    {
        LevelsUI.SetActive(true);
    }

    public void OpenSettings()
    {
        SettingsUI.SetActive(true);
    }

    public void CloseLevels()
    {
        LevelsUI.SetActive(false);
    }

    public void CloseSettings()
    {
        SettingsUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Player has Quit the game!");
        Application.Quit();
    }
    
    // Levels teleport
    public void Level1()
    {
        SceneManager.LoadScene(0);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
}

