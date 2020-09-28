using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    public GameObject pointer;

    public float moveSpeed;

    private Rigidbody2D _theRB;
    
    private void Awake()
    {
        _theRB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Vector2 direction = transform.position - pointer.transform.position;
        _theRB.velocity = direction * moveSpeed;
    }
    
    void Update()
    {
        
    }
}
