using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public static bool isStart;
    [SerializeField] private GameObject startCanvas;

    private void Awake()
    {
        isStart = false;
        startCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Launch()
    {
        isStart = true;
        startCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
