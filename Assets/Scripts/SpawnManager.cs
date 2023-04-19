using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] peoplePrefabs;
    public GameObject[] obstaclePrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPeople", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomObstacles", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomPeople()
    {
        int peopleIndex = Random.Range(0, peoplePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(peoplePrefabs[peopleIndex], spawnPos, peoplePrefabs[peopleIndex].transform.rotation);
    }

    void SpawnRandomObstacles()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}

