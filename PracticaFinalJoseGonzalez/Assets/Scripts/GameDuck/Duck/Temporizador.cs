using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public GameObject startPanel, gamePanel, endPanel;
    public Text timeLeftText;
    public float playTime;
    private float timeLeft;

    private bool timeIsTicking = false;

    private int numberOfDuck = 0;
    public int targetNumberOfDuck = 10;
    public Text numberOfDuckText;
    public Text gameOverText;

    private string maxScoreKey = "maxScore";

    private void Start()
    {
    }

    public void Click()
    {
        numberOfDuck++;
        numberOfDuckText.text = numberOfDuck.ToString();
    }

    public void Restart()
    {
        numberOfDuck = 0;
        numberOfDuckText.text = numberOfDuck.ToString();
    }

    public void StartCountDown()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0.00");
            if (timeLeft < 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
        CheckWinningConditions();
    }

    private void CheckWinningConditions()
    {
        if (PointManager.instance.currentPoints >= targetNumberOfDuck)
        {
            int maxScore = PlayerPrefs.GetInt(maxScoreKey);

            if (numberOfDuck > maxScore)
            {
                gameOverText.text = "felicidades has derribado " + numberOfDuck +
                    " de los " + targetNumberOfDuck + " has alcanzado un nuevo record";

                PlayerPrefs.SetInt(maxScoreKey, numberOfDuck);
            }
            else
            {
                gameOverText.text = "felicidades has derribado a " + numberOfDuck +
                    " de los " + targetNumberOfDuck + " necesarios,  el record son " + maxScore;
            }
        }
        else
        {
            gameOverText.text = "No has llegado a numero de patos derribados necesarios :( " + targetNumberOfDuck;
        }
    }
}