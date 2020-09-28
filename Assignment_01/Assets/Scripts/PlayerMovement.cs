using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _pC;
    public float moveSpeedX;
    public float moveSpeedY;
    public Rigidbody2D theRB;

    private void Start()
    {
        _pC = GetComponent<PlayerController>();
    }
    private void LateUpdate()
    {
        theRB.velocity = new Vector2(moveSpeedX * _pC.inputX, moveSpeedY * _pC.inputY);

    }
}
