using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public BallSpawnerScript bSS;
    public BallEnergizedScript bE;
    public BossSpawnerScript bS;
    public PlayerHealthController pH;

    public bool isGrunt;

    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (bE.energizeball)
            {
                if (isGrunt)
                {
                    bS.SpawnBoss();
                    bE.energizeball = false;
                    Destroy(gameObject);
                    Destroy(other.gameObject);
                    bSS.SetSpawnable();
                }
                else
                {
                    bSS.SetSpawnable();
                    Destroy(gameObject);
                    Destroy(other.gameObject);
                }

            }
            else
            {
                Destroy(other.gameObject);
                bSS.SetSpawnable();
            }

        }
        else if (other.tag == "Player")
        {
            if (isGrunt)
            {

                pH.DealDamage();
            }
            else
            {
                pH.DealDamage();

            }
        }
    }
}
