using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnSpots;
    public float startTimeBetweenSpawns;


    private float timeBetweenSpawns;


    public void Start()
    {
        timeBetweenSpawns = startTimeBetweenSpawns;
    }


    public void Update()
    {
        if (timeBetweenSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBetweenSpawns = 2;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }

    }
}
