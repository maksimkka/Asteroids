using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour, IGameOver
{
    [SerializeField] private GameObject gameOverCanvas;

    private void Awake()
    {
        gameOverCanvas.SetActive(false);
    }

    public void GameOver()
    {
        StartGame.isStarted = false;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        StartGame.isStarted = true;
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
