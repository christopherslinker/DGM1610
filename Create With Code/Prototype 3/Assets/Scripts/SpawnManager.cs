using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclesPrefab;

    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;

    private float repeatDelay = 2;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclesPrefab, spawnPos, obstaclesPrefab.transform.rotation);
    }
}
