using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public bool isGrunt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // <- Change this to "Ball"
        {
            // PlayerHealthController.instance.DealDamage();
            // LevelManager.instance.RespawnPlayer();
            if (isGrunt)
            {
                Destroy(gameObject);

                // Instantiate(spawnBoss, spawnPointBoss, transform.rotation);             


            }
            else
            {
                Destroy(gameObject);
            }
            

        }
    }
}
