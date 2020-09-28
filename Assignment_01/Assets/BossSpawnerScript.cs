using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnerScript : MonoBehaviour
{
    public GameObject whatToSpawn;

    public bool spawnBoss;
    public void Awake()
    {
        whatToSpawn.SetActive(false);
    }
    void Start()
    {

    }

    public void SpawnBoss()
    {
        whatToSpawn.SetActive(true);
    }
    void Update()
    {

    }
}
