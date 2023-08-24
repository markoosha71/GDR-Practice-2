using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    //This variable will make the enemies not spawn within a certain range of the player.
    public bool SpawnerWithinRadiusOfPlayer;

    public float timeBetweenSpawns;
    float nextSpawnTime;

    public List<Transform> spawnPoints;

    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        //Spawner Scrip will play if the Spawner is outside of a certain Radious of the player
        if (SpawnerWithinRadiusOfPlayer == false)
        {
            if (Time.time > nextSpawnTime)
            {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
                Instantiate(enemy, randomSpawnPoint.position, randomSpawnPoint.rotation);

                nextSpawnTime = Time.time + timeBetweenSpawns;

            }
        }


    }
}
