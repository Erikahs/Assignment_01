using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    
    public float moveSpeedX;
    public float moveSpeedY;
    public Rigidbody2D theRB;
    public LayerMask hitlayer; //Används EJ


    void Update()
    {

        theRB.velocity = new Vector2(moveSpeedX * Input.GetAxis("Horizontal"), moveSpeedY * Input.GetAxis("Vertical"));
       // theRB.velocity = new Vector2(theRB.velocity.y,);
        
    }
}
