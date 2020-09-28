using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnergizedScript : MonoBehaviour
{
    public bool energizeball;
    void Start()
    {
        energizeball = false;
    }

    public void EnergizeBall()
    {
        energizeball = true;
    }

    void Update()
    {

    }
}
