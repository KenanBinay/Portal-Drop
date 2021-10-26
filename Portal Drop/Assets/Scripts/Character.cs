using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   public float spinSpeed;
   public static float ScoreControl;
    void Start()
    {
        ScoreControl = 0f;
    }
   
    void Update()
    {
        gameObject.transform.Rotate(Vector3.back * spinSpeed, Space.World);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Wall");
            ScoreControl = 1f;
            if (Score.scoreValue > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore",Score.scoreValue);
                Debug.Log("HigScore Saved = "+ PlayerPrefs.GetFloat("HighScore"));
            }
        }
        if (collision.gameObject.CompareTag("portalDown"))
        {
            transform.position = new Vector3(-1.804f, 4f, 0f);
            Debug.Log("PortalDown");
        }
        if (collision.gameObject.CompareTag("portalUp"))
        {
            transform.position = new Vector3(-1.804f, -4f, 0f);
            Debug.Log("PortalUp");
        }
    }
}
