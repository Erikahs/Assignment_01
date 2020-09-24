using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    public GameObject spawnBoss;
    // Start is called before the first frame update

    public void Awake()
    {
        spawnBoss.SetActive(false);
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

            Destroy(gameObject);

            // Instantiate(spawnBoss, spawnPointBoss, transform.rotation);             

            spawnBoss.SetActive(true);



        }
    }
}
