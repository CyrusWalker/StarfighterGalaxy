using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon3Controller : MonoBehaviour
{
    [SerializeField] private Weapon3 weapon;
    [SerializeField] private float randomWaitTime;
    [SerializeField] private float maxWaitTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        randomWaitTime = Random.Range(0.5f, maxWaitTime);
    }

    // Update is called once per frame
    void Update()
    {
        randomWaitTime -= Time.deltaTime;
        if(randomWaitTime <= 0) {
            weapon.Shoot();
        }
        randomWaitTime = Random.Range(0.5f, maxWaitTime);
    }
}
