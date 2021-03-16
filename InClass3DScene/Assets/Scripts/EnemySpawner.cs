using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;

    private float spawnRangeX = 4;

    private float spawnPosZ = -180;

    private float startDelay = 2;

    private float startInterval = 1.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, startInterval);
    }

    void Update()
    {
        //nothing here... for now.
    }

    void SpawnRandomEnemy()
    {

    }
}
