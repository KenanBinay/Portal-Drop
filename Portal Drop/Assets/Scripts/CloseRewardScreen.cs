using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRewardScreen : MonoBehaviour
{
    public GameObject gameEnd;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void rewardClose()
    {
        gameEnd.SetActive(true);
        GameOver.rewardCountdown = 0f;
    }
}
