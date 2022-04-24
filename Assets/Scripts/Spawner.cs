using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] asteroidPatterns;

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

            int rand = Random.Range(0, asteroidPatterns.Length);
            Instantiate(asteroidPatterns[rand], transform.position, Quaternion.identity);
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
