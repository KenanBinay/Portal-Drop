using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D character;
    public float SpeedCharacter;

    public GameObject TutoObject1;
    public GameObject TutoObject2;
    public GameObject TutoObject3;
    private void Start()
    {
        character.gravityScale = 0f;
     
    }
    public void OnMouseExit()
    {

    }
    public void OnMouseDrag()
    {
        Destroy(TutoObject1);
        Destroy(TutoObject2);
        Destroy(TutoObject3);
        character.gravityScale = 1f;
        // Character.gravityScale = 0f;
        // Character.mass = 0f;
        character.GetComponent<Rigidbody2D>().AddForce(Vector2.up * SpeedCharacter);
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
