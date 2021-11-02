using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagment : MonoBehaviour
{
    public static float ScoreSpeed;
    public GameObject ScoreObject;

    private void Start()
    {
    
    }

    private void Update()
    {
       transform.Translate(Vector2.left * ScoreSpeed, Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallDetect"))
        {    
            Debug.Log("WallDetect");
            Destroy(ScoreObject);
        }
        if (collision.gameObject.CompareTag("Character"))
        {

            Score.scoreValue += 10;
            Debug.Log("ScoreEarned");
          //  StartCoroutine(GetColor());
            Destroy(ScoreObject);
     
        }
    }
 /*   public IEnumerator GetColor()
    {
        yield return new WaitForSeconds(0.30f);

        Debug.Log("ColorChange");
    }
   */
}
