using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static float WallSpeed;
    private void Start()
    {
      
    }
    private void Update()
    {
        transform.Translate(Vector2.left * WallSpeed, Space.World);
    }

    public GameObject wall1;
    public GameObject wall2;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "WallDetect")
        {
            Destroy(wall1);
            Destroy(wall2);
        }

       

    }
}
