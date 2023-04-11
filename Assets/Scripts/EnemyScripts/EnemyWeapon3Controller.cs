using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon3Controller : MonoBehaviour
{
    [SerializeField] private Weapon3 weapon;
    [SerializeField] private float randomWaitTime;

    void Start()
    {
        randomWaitTime = Random.Range(0.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        randomWaitTime -= Time.deltaTime;
        if(randomWaitTime <= 0) {
            weapon.Shoot();
        }
        randomWaitTime = Random.Range(0.5f, 3f);
    }
}
