using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] obstacles; // Array untuk menyimpan berbagai jenis obstacle
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        if (obstacles.Length == 0) return; 
        
        int randomIndex = Random.Range(0, obstacles.Length); 
        float randomX = Random.Range(minX, maxX);
        float randomY;

        if (randomIndex == 1 || randomIndex == 2 || randomIndex == 3 || randomIndex == 4)
        {
            randomY = Random.Range(-4.5f, -3f);
        }
        else
        {
            randomY = Random.Range(minY, maxY);
        }

        Instantiate(obstacles[randomIndex], transform.position + new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}
