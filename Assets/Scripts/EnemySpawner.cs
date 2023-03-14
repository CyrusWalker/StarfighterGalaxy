using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    private float randPosition;
    private Vector2 spawnPosition;
    public float spawnRate = 2.0f;
    private float nextSpawn = 0.0f;

    public List<GameObject> enemyList;
    private GameObject randomEnemy;

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

    private void SpawnEnemy()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randPosition = Random.Range(-2.4f, 2.4f);
            spawnPosition = new Vector2(randPosition, 0);
            Instantiate(RandomEnemy(), spawnPosition, Quaternion.identity, this.transform);
        }
    }
    
    void Update()
    {
        SpawnEnemy();
    }
}
