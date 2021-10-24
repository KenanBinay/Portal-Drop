using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDown : MonoBehaviour
{
    public GameObject Character;
    public Rigidbody2D portalUp;
    float dirY;
    void Start()
    {

        dirY = Input.GetAxisRaw("Vertical");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
       
       // Instantiate(Character, portalUp.position, Quaternion.identity);
  
    }
}
