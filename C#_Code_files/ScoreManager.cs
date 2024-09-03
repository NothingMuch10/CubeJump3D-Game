using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public UIManager uiManager;

    void Start()
    {
        uiManager.ShowStartScreen();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        uiManager.ShowScoreScreen(score);
    }

    public void EndGame()
    {
        uiManager.ShowGameOverScreen(score);
    }
}