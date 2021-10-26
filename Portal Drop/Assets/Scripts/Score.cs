using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text score;
    public static float scoreValue;
    float scoreRate = 1.5f;
    float scorespeed = 0.0f;

    void Start()
    {
        Debug.Log("HigScore = " + PlayerPrefs.GetFloat("HighScore"));
      
    }

    void Update()
    {
        if (Character.ScoreControl != 1f)
        {
            if (Time.time > scorespeed)
            {
                //  int scorenumb = 0;

                scorespeed = Time.time + scoreRate;

                if (scoreValue < 40)
                {

                    scoreValue++;
                    score.text = scoreValue.ToString();

                }

                if (scoreValue >= 40)
                {
                    scoreRate = 1f;
                    scoreValue++;
                    // scoreValue = scoreValue + 2;
                    score.text = scoreValue.ToString();
                }

                if (scoreValue >= 90)
                {
                    scoreRate = 0.5f;
                    scoreValue++;
                    // scoreValue = scoreValue + 2;
                    score.text = scoreValue.ToString();
                }

            }

        }
    }
}
