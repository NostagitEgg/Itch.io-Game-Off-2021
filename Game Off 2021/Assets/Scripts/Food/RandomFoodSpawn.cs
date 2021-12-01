using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFoodSpawn : MonoBehaviour
{

    public GameObject Food;
    public float Radius = 5f;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnFoodAtRandom", 1f, 1f);
    }

    //Spawnfood at random, credits to Chillidev's yt tutorial
    void SpawnFoodAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        Instantiate(Food, randomPos, Quaternion.identity);
    }
}
