using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int countScore;
    [SerializeField] private Text scoreText;

    private void Start()
    {
        IncreaseScore(0);
    }

    public void IncreaseScore(int score)
    {
        countScore += score;
        scoreText.text = $"SCORE: {countScore}";
    }
}
