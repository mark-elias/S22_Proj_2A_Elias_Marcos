using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject asteroid;

    private float timeBetweenSpawn;

    // gaps between spawn times
    public float startTimeBetweenSpawn;

    // so that asteriods spawn faster throughout game
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            Instantiate(asteroid, transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;

            if (startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreaseTime;

            }

        }

        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }


    }
}
