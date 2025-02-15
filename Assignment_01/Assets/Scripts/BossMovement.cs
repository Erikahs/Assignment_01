﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float moveSpeed;

    public Transform leftPoint, rightPoint;

    private bool _movingRight;

    private Rigidbody2D _theRB;

    // Start is called before the first frame update
    void Start()
    {
        _theRB = GetComponent<Rigidbody2D>();

        _movingRight = true;

        leftPoint.parent = null;
        rightPoint.parent = null;
    }

    // Update is called once per frame
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
