using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    private int score = 0;
    private float timeRemaining = 60f;
    private bool isGameOver = false;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        UpdateScoreText();
        UpdateTimerText();
    }

    void Update()
    {
        if (!isGameOver)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();

            if (timeRemaining <= 0)
            {
                GameOver();
            }
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    { 
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimerText()
    {
        timerText.text = "Time: " + Mathf.Ceil(timeRemaining);
    }

    public void GameOver()
    {
        isGameOver = true;
    }
}
