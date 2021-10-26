using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameAndHighScore : MonoBehaviour
{
    public Text HighScoreMenu;
    void Start()
    {
        HighScoreMenu.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
        if(PlayerPrefs.GetFloat("HighScore", 0) == 0)
        {
            HighScoreMenu.text = null;
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
