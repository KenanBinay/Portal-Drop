using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameOver : MonoBehaviour
{
    public Text score2;
    public Text highScore;
    float GameoverScore=0f;
    float scorespeed = 0.0f;
    float scoreRate = 1.5f;
    public GameObject gameEnd;
    public GameObject character;
    public GameObject CloseReward;
    public GameObject CloseIconReward;
    public Text Countdown;
    float BestScore;

    float RewardRate = 1.5f;
    public static float rewardCountdown=10f;

    void Start()
    {
        rewardCountdown = 10f;
        gameEnd.SetActive(false);
        CloseReward.SetActive(false);
        CloseIconReward.SetActive(false);
    }
    void Update()
    {
        if (Character.ScoreControl >= 1f)
        {
           
            character.SetActive(false);
            ExtraLifeShow();
        }   
    }
    private void ExtraLifeShow()
    {
        if (rewardCountdown <= 0f)
        {
            CloseIconReward.SetActive(false);
            CloseReward.SetActive(false);

            gameEnd.SetActive(true);
            GameEndShow();

        }
        else
        {
            if (Advertisement.IsReady("Rewarded_Android"))
            {
                CloseIconReward.SetActive(true);
                CloseReward.SetActive(true);

                if (Time.time > scorespeed)
                {
                    scorespeed = Time.time + RewardRate;
                    Countdown.text = rewardCountdown.ToString();
                    rewardCountdown--;
                }
            }
            else
            {
                Debug.Log("Rewarded is not ready!!");
                gameEnd.SetActive(true);
                GameEndShow();
            }
           
        }
    }
    private void GameEndShow()
    {
        BestScore = PlayerPrefs.GetFloat("HighScore", 0);
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
        else
        {
            character.SetActive(true);
            gameEnd.SetActive(false);
        }
    }
}
