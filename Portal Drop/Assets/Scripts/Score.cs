using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour, IUnityAdsListener
{
    public Text score;
    public static float scoreValue=0f;
    float scoreRate = 1.5f;
    float scorespeed = 0.0f;

    public GameObject CloseReward;
    public GameObject CloseIconReward;
    void Start()
    {
        Advertisement.Initialize("4414087");
        Advertisement.AddListener(this);
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

                if (scoreValue < 90)
                {

                    scoreValue++;
                    score.text = scoreValue.ToString();

                }

                if (scoreValue >= 100)
                {
                    scoreRate = 1f;
                    scoreValue++;
                    // scoreValue = scoreValue + 2;
                    score.text = scoreValue.ToString();
                }

                if (scoreValue >= 500)
                {
                    scoreRate = 0.5f;
                    scoreValue++;
                    // scoreValue = scoreValue + 2;
                    score.text = scoreValue.ToString();
                }

            }

        }
        else
        {
            if (Advertisement.IsReady("Rewarded_Android"))
            {
                CloseIconReward.SetActive(true);
                CloseReward.SetActive(true);
                if (RewardedAds.AdWatched == 1f)
                {
                    Advertisement.Show("Rewarded_Android");
                    RewardedAds.AdWatched = 0f;
            
                }
            }
            else
            {
                Debug.Log("Rewarded is not ready!!");
            }
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("ADS READY");
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("ERROR: " + message);
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("VIDEO STARTED");
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            GameOver.rewardCountdown = 10f;
            Character.ScoreControl = 0f;
            SceneManager.LoadScene("GamePlay");
        }
            throw new System.NotImplementedException();
    }
}
