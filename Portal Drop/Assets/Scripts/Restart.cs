using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{

    void Start()
    {
        
    }

    public void Res()
    {
        Score.scoreValue = 0f;
        Character.ScoreControl = 0f;
        GameOver.rewardCountdown = 10f;
        SceneManager.LoadScene("GamePlay");
    }
}
