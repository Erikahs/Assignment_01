using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public PlayerHealthController pH;
    public BallEnergizedScript bE;
    void Start()
    {

    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pH.DealDamage();
        }

        if (other.tag == "Ball")
        {
            bE.EnergizeBall();
        }
    }
}
