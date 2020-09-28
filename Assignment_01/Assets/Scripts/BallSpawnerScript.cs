using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject pointer;
    public GameObject ball;
    public bool spawnable;

    void Start()
    {
        spawnable = true;
    }

    void Update()
    {

    }

    public void SpawnBall()
    {
        if (spawnable)
        {
            Instantiate(ball, pointer.transform.position, transform.rotation);
            spawnable = false;
        }
    }

    public void SetSpawnable()
    {
        spawnable = true;
    }
}
