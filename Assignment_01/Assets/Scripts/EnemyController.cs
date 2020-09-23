using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;
    public static EnemyController instance2;

    public bool isGrunt;
    // public bool isBoss;

    public GameObject spawnBoss;

    private Vector3 spawnPointBoss;

    //GameObject _bE;

    public void Awake()
    {
        instance = this;

        spawnPointBoss = new Vector3(2.25f, -0.96f, 0f);

        EnemyController.instance.spawnBoss.SetActive(false);


    }

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
                
                
                    EnemyController.instance.spawnBoss.SetActive(true);
               
            }

           
        }

                    
                      
    }

    
}
