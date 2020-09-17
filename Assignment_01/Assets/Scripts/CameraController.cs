using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update

    public float minY, maxY;
    public float minX, maxX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    
    
    }
}
