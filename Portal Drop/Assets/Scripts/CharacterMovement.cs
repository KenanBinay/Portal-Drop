using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D Character;
    public GameObject CharacterGo;
    public float SpeedCharacter;

    public void OnMouseExit()
    {

    }
    public void OnMouseDrag()
    {
        // Character.gravityScale = 0f;
        // Character.mass = 0f;
        Character.GetComponent<Rigidbody2D>().AddForce(Vector2.up * SpeedCharacter);
        //  Character.AddForce(Vector2.up * SpeedCharacter);
       //  CharacterGo.transform.Translate(Vector2.up * SpeedCharacter, Space.World);     
    }
   private void LateUpdate()
    {
        //CharacterGo.transform.Translate(Vector2.down * 0.03f, Space.World);
        // Character.gravityScale = 1f;
        // Character.mass = 1f;
        //CharacterGo.transform.Translate(Vector2.up * 0.03f, Space.World);
    }
   
}
