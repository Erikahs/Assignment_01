using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public float inputX;
    public float inputY;
    private PointerRotation _pR;
    private Camera _camera;

    public BallSpawnerScript bS;
    public BallEnergizedScript bE;
    public void Awake()
    {
        instance = this;
        _camera = Camera.main;

        _pR = GetComponent<PointerRotation>();
    }

    void Start()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        _pR.aimAtPosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            bS.SpawnBall();
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            Destroy(other.gameObject);
            bS.SetSpawnable();
            bE.energizeball = false;

        }

    }
}
