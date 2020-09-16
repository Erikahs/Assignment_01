using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float aimRotationSpeed = 5f;
    
    [NonSerialized] public Vector2 aimAtPosition;

    
    private Transform _pointer;
    private Transform _transform;
    private Camera _camera;

    



    public bool IsAimable
    {
        get
        {
            return !Mathf.Approximately(aimRotationSpeed, 0f);
        }
    }

    private void Awake()
    {
        _camera = Camera.main;
        _transform = transform;
        _pointer = _transform.Find("Pointer");
    }

    void Update()
    {
        aimAtPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
       
    }
    private void LateUpdate()
    {
        if (IsAimable)
        {
            AimPointer();  
        }
    }

    private void AimPointer()
    {
        Vector2 direction = aimAtPosition - (Vector2)_pointer.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        _pointer.rotation = Quaternion.Slerp(_pointer.rotation, rotation, aimRotationSpeed * Time.deltaTime);

    }


    
    
}
