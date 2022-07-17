using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnManager : MonoBehaviour
{
    public GameObject[] coinPrefabs; // Array to store coins 

    private float spawnRangeX = 20f;

    private float spawnPosZ = 10f;

    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomCoin", startDelay, spawnInterval);
    }

        // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCoin()
    {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
         int coinIndex = Random.Range(0,coinPrefabs.Length); // Picks a random coin from the array
         Instantiate(coinPrefabs[coinIndex], spawnPos, coinPrefabs[coinIndex].transform.rotation); // Spanws indexed coin from the array at a random location on the x axis
    }
}
