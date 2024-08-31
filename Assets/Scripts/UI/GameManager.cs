using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject highScorePanel;
    
    void Update()
    {
        CheckGameOver();
    }

    void CheckGameOver()
    {
        if (Time.timeScale == 0)
        {
            gameOverPanel.SetActive(true);
            highScorePanel.SetActive(true);
        }
        
        if (Score.scoreValue > Score.highScoreValue)
        {
            Score.highScoreValue = Score.scoreValue;
        }
    }
    

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverPanel.SetActive(false);
        highScorePanel.SetActive(false);
        Score.scoreValue = 0;
    }
}
