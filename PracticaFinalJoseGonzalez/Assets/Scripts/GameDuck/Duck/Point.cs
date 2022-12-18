using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointManager : MonoBehaviour
{
    public static PointManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI highscoreText2;

    private int score = 0;
    private int highscore = 0;
    private int score2 = 0;
    private int highscore2 = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscore2 = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "PUNTOS: " + score.ToString();
        scoreText2.text = "PUNTOS: " + score2.ToString();
        highscoreText.text = "MÁXIMA PUNTUACIÓN: " + highscore.ToString();
        highscoreText2.text = "MÁXIMA PUNTUACIÓN: " + highscore2.ToString();
    }

    public void AddPoint()
    {
        score += 10;
        score2 += 10;
        scoreText.text = "PUNTOS: " + score.ToString();
        scoreText2.text = "PUNTOS: " + score2.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);

        if (highscore2 < score2)
            PlayerPrefs.SetInt("highscore", score);
    }
}