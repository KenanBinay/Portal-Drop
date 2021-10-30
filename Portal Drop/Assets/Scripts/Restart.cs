using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
     Animation gameEndClose;
    void Start()
    {
        
    }

    public void Res()
    {
      //  gameEndClose.Play("GameOverAnim");
        Score.scoreValue = 0f;
        Character.ScoreControl = 0f;
        GameOver.rewardCountdown = 10f;
        SceneManager.LoadScene("GamePlay");
    }


}
