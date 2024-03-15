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
    public float spawnRangeX = 40f;
    public float spawnThresholdY = 50f;
    public List<GameObject> enemyList;
    private GameObject randomEnemy;
    public AudioClip[] EnemySpawnSFX;
    public AudioSource Source;

    void Update()
    {
        if (endlessMode)
        {
            EndlessSpawn();
        }
        else
        {
            NormalSpawn();
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
            SpawnEnemy();
        }
    }

    private void NormalSpawn()
    {
        if (Time.time > nextSpawn)
        {
            if (spawnCount < spawnMax)
            {
                SpawnEnemy();
                spawnCount++;
            }
        }
    }
    
    private void SpawnEnemy()
    {
        nextSpawn = Time.time + spawnRate;
        randPositionX = Random.Range(-spawnRangeX, spawnRangeX);
        spawnPosition = new Vector2(randPositionX, spawnThresholdY);
        Instantiate(RandomEnemy(), spawnPosition, Quaternion.identity, this.transform);
        PlayEnemySFX();
    }

    private void PlayEnemySFX()
    {
        AudioClip RandomSFX = EnemySpawnSFX[Random.Range(0, EnemySpawnSFX.Length)];
        Source.clip = RandomSFX;
        Source.Play();
    }
}
