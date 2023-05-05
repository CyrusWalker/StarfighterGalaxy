using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    private float randPositionX;
    private Vector2 spawnPosition;
    public float spawnRate = 2.0f;
    private float nextSpawn = 0.0f;
    public int spawnCount = 0;
    public int spawnMax = 5;
    public bool endlessMode = false;

    public List<GameObject> enemyList;
    private GameObject randomEnemy;

    void Update()
    {
        if (endlessMode)
        {
            EndlessSpawn();
        }
        else
        {
            SpawnEnemy();
        }
    }

    private GameObject RandomEnemy()
    {
        var randomTemp = Random.Range(0, enemyList.Count);

        for (int i = 0; i < enemyList.Count; i++)
        {
            if (i == randomTemp)
            {
                randomEnemy = enemyList[i];
            }
        }
        return randomEnemy;
    }

    private void EndlessSpawn()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randPositionX = Random.Range(-50f, 50f);
            spawnPosition = new Vector2(randPositionX, 50f);
            Instantiate(RandomEnemy(), spawnPosition, Quaternion.identity, this.transform);
        }
    }

    private void SpawnEnemy()
    {
        if (Time.time > nextSpawn)
        {
            if (spawnCount < spawnMax)
            {
                nextSpawn = Time.time + spawnRate;
                randPositionX = Random.Range(-50f, 50f);
                spawnPosition = new Vector2(randPositionX, 50f);
                Instantiate(RandomEnemy(), spawnPosition, Quaternion.identity, this.transform);
                spawnCount++;
            }
        }
    }
}
