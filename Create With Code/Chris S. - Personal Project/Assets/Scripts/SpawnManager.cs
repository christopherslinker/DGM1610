﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 7.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    private float powerUpSpawnTime = 5.0f;
    private float enemySpawnTime = 3.0f;
    private float startDelay = 1.0f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerUpSpawnTime);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    

    void SpawnRandomEnemy()
    {
        
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);
        
        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
        }
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

            Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
        }
    }
}
