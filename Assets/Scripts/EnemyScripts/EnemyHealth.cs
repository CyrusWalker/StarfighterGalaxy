using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHitPoints = 100;
    public int currentHitPoints;
    // Start is called before the first frame update
    void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage) {
        currentHitPoints -= damage;
        if(currentHitPoints <= 0) {
            Die();
        }
    }

    private void Die() {
        Destroy(gameObject);
    }
}
