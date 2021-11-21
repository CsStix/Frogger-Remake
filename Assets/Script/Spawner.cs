using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnTime = .3f;
    public GameObject car;
    float nexttimetospawn = 0f;
    public Transform[] spawnpoints;


    private void Update()
    {
        if (nexttimetospawn <= Time.time)
        {
            SpawnCar();
            nexttimetospawn = Time.time + spawnTime;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnpoints.Length);
        Transform spawnpoint = spawnpoints[randomIndex];

      Instantiate(car, spawnpoint.position, spawnpoint.rotation);
    }




}
