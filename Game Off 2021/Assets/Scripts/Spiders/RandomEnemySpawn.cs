using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    public GameObject Web;
    public float Radius = 5f;

    public GameObject Spider;
    public GameObject Spider2;
    public GameObject Spider3;
    public GameObject Spider4;

    Vector2 pos1;
    Vector2 pos2;
    Vector2 pos3;
    Vector2 pos4;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWebatRandom", 0.5f, 0.5f);
        InvokeRepeating("SpawnSpider1atRandom", 0.5f, Random.Range(0, 10));
        InvokeRepeating("SpawnSpider2atRandom", 0.5f, Random.Range(0, 10));
        InvokeRepeating("SpawnSpider3atRandom", 0.5f, Random.Range(0, 10));
        InvokeRepeating("SpawnSpider4atRandom", 0.5f, Random.Range(0, 10));

        pos1 = new Vector2(-6, -3);
        pos2 = new Vector2(-6, 3);
        pos3 = new Vector2(6, 3);
        pos4 = new Vector2(6, -3);
    }
 
    void SpawnWebatRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        Instantiate(Web, randomPos, Quaternion.identity);  
        
    }

    void SpawnSpider1atRandom()
    {
        Instantiate(Spider, pos1, Quaternion.AngleAxis(310, new Vector3(0, 0, 310)));
        
        
        Instantiate(Spider4, pos4, Quaternion.AngleAxis(50, new Vector3(0, 0, 50)));
    }

    void SpawnSpider2atRandom()
    {
        Instantiate(Spider2, pos2, Quaternion.AngleAxis(230, new Vector3(0, 0, 230)));
    }

    void SpawnSpider3atRandom()
    {
        Instantiate(Spider3, pos3, Quaternion.AngleAxis(130, new Vector3(0, 0, 130)));
    }

    void SpawnSpider4atRandom()
    {
        Instantiate(Spider4, pos4, Quaternion.AngleAxis(50, new Vector3(0, 0, 50)));
    }
}
