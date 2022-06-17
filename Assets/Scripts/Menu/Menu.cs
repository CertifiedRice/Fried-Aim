using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject GameModesUI;
    public GameObject SettingsUI;
    public GameObject accuracyUi;
    public GameObject gamemodesButtons;

    public void PlayLevels()
    {
        GameModesUI.SetActive(true);
    }

    public void OpenSettings()
    {
        SettingsUI.SetActive(true);
    }

    public void CloseLevels()
    {
        GameModesUI.SetActive(false);
    }

    public void CloseSettings()
    {
        SettingsUI.SetActive(false);
    }

    public void GameModeAccuracy()
    {
        accuracyUi.SetActive(true);
        gamemodesButtons.SetActive(false);
    }

    public void AccuracyMoreGameModes()
    {
        accuracyUi.SetActive(false);
        gamemodesButtons.SetActive(true);
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