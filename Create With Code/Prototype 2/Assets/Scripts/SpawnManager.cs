﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;

    private float SpawnPosZ = 20;

    private float startDelay = 2;

    private float startInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int animalIndex = Random.Range(0, animalPrefabs.Length);
                
        Instantiate(animalPrefabs [animalIndex], SpawnPos,
            animalPrefabs [animalIndex].transform.rotation); 
    }
}
