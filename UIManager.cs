using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startCanvas;       
    public GameObject scoreCanvas;   
    public GameObject gameOverCanvas;    
    public Text scoreText;               

    private void Start()
    {
        ShowStartScreen();
    }

    
    public void StartGame()
    {
        startCanvas.SetActive(false);   
        scoreCanvas.SetActive(true);   
        gameOverCanvas.SetActive(false); 
       
    }

    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }
 
    public void ShowScoreScreen(int score)
    {
        scoreCanvas.SetActive(true);  
        gameOverCanvas.SetActive(false); 
        scoreText.text = "Score: " + score; 
    }

   
    public void ShowGameOverScreen(int score)
    {
        scoreCanvas.SetActive(false); 
        gameOverCanvas.SetActive(true); 
        Text gameOverText = gameOverCanvas.GetComponentInChildren<Text>(); 
        gameOverText.text = "Game Over\nScore: " + score; 
    }

    public void ShowStartScreen()
    {
        startCanvas.SetActive(true);  
        scoreCanvas.SetActive(false); 
        gameOverCanvas.SetActive(false);
    }
}