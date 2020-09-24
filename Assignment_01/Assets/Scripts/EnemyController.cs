using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool isGrunt;
    public bool isBoss;

    public GameObject spawnBoss;
     
         
    public void Awake()
    {
        spawnBoss.SetActive(false);
    }

    void Start()
    {
      
        

       
    }    
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

                spawnBoss.SetActive(true);
            }


        }

        if (other.tag == "Player") // <- Change this to "Ball"
        {
            // PlayerHealthController.instance.DealDamage();
            // LevelManager.instance.RespawnPlayer();
            if (isBoss)
            {
                Destroy(gameObject);

            }

        }
    }
}
