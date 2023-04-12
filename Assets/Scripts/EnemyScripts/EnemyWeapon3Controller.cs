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
        SetWaitTime();
    }

    // Update is called once per frame
    void Update()
    {
        randomWaitTime -= Time.deltaTime;
        if(randomWaitTime <= 0) {
            weapon.Shoot();
            SetWaitTime();
        }
    }

    void SetWaitTime() {
        randomWaitTime = Random.Range(0.5f, maxWaitTime);
    }
}
