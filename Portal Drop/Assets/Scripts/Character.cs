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
}
