using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class RewardedAds : MonoBehaviour
{
    public static float AdWatched;
   
    void Start()
    {
       
    }

    public void ShowRewardedAd()
    {
        AdWatched = 1f;
        Debug.Log("AdWatched: " + AdWatched);
    }
}
