using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   public float spinSpeed;
    void Start()
    {
        
    }
   
    void Update()
    {
        gameObject.transform.Rotate(Vector3.back * spinSpeed, Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
