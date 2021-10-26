using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public Text score2;
    public Text highScore;
    float GameoverScore;
    float scorespeed = 0.0f;
    float scoreRate = 1.5f;
    public GameObject gameEnd;
    public GameObject character;
    float BestScore;
    void Start()
    {
        gameEnd.SetActive(false);

    }

    void Update()
    {
        if (Character.ScoreControl >= 1f)
        {
            character.SetActive(false);
            gameEnd.SetActive(true);
            BestScore = PlayerPrefs.GetFloat("HighScore",0);
            highScore.text = BestScore.ToString(); 
            if (Time.time != scorespeed)
            {
                scorespeed = Time.time + scoreRate;
                if (GameoverScore != Score.scoreValue)
                {
                    GameoverScore++;
                    score2.text = GameoverScore.ToString();
                }

            }
        }
        else
        {
            character.SetActive(true);
            gameEnd.SetActive(false);
        }
    }
}
