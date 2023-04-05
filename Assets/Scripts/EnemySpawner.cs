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
    private int spawnCount = 0;
    public int spawnMax = 5;

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
    
    void Update()
    {
        SpawnEnemy();
    }
}
