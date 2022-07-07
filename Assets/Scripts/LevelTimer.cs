using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

public class LevelTimer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;
    public int timeRemaining = 60;

    private GameOver _gameOver;

    [Inject]
    private void Construct(GameOver gameOver)
    {
        _gameOver = gameOver;
    }

    private void Start()
    {
        DisplayTime(timeRemaining);
        StartCoroutine(nameof(TimerCountdown));
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    IEnumerator TimerCountdown()
    {
        for (int i = timeRemaining; i > 0; i--)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
            DisplayTime(timeRemaining);
        }
        _gameOver.ShowGameOverPanel();
    }
}
