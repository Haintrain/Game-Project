﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class MapMenu : MonoBehaviour
{
    public List<GameObject> levels;


    void Start()
    {
        Time.timeScale = 1;
        GameyManager.gameState = GameyManager.GameState.Menu;
        if(GameyManager.levelsCompleted != levels.Count)
        {
            levels[GameyManager.levelsCompleted].GetComponentsInChildren<Image>()[1].enabled = false;
        }
        
        for(int i=GameyManager.levelsCompleted+1; i<levels.Count; i++)
        {
            levels[i].SetActive(false);
        }
    }

    public void Tutorial(int value)
    {
        SceneManager.LoadScene("Tutorial_"+value);
    }

    public void Level(int value)
    {
        SceneManager.LoadScene("Level_"+value);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void UnlockAll()
    {
        GameyManager.levelsCompleted = levels.Count;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
