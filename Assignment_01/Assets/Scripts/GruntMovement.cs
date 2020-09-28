using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntMovement : MonoBehaviour
{
    public float moveSpeed;

    public Transform leftPoint, rightPoint;

    private bool _movingRight;

    private Rigidbody2D _theRB;

    void Start()
    {
        _theRB = GetComponent<Rigidbody2D>();

        _movingRight = true;

        leftPoint.parent = null;
        rightPoint.parent = null;
    }
    void Update()
    {
        if (_movingRight)
        {
            _theRB.velocity = new Vector2(moveSpeed, _theRB.velocity.y);

            if (transform.position.x > rightPoint.position.x)
            {
                _movingRight = false;
            }
        }
        else
        {
            _theRB.velocity = new Vector2(-moveSpeed, _theRB.velocity.y);

            if (transform.position.x < leftPoint.position.x)
            {
                _movingRight = true;
            }
        }
    }
}
