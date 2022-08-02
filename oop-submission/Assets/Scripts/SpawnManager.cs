using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnDelay = 3f;
    private float spawnInterval = 1.5f;
    private float xRange = 50f;
    private float zRange = 50f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-xRange, xRange), 1, Random.Range(-zRange, zRange));
        int index = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[index], spawnLocation, enemyPrefabs[index].transform.rotation);
    }
}
