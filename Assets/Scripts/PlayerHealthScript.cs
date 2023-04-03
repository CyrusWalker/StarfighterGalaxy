using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int maxLife = 100;
    public int currentHitPoints;
    public int hearts = 3;
    [SerializeField] private float InvulnerabilityTimerMax;
    public float InvulnerabilityTimer;

    // Start is called before the first frame update
    void Start() {
        currentHitPoints = maxLife;
    }
    
    void Update() {
        if(InvulnerabilityTimer > 0) {
            InvulnerabilityTimer -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damage) {
        if(InvulnerabilityTimer <= 0) {
            DealDamageToPlayer(damage);
        }
    }

    void ReduceHearts() {
        hearts--;
        if(hearts <= 0) {
            Die();
        }
    }
    
    void Die() {
        //stub, do restart level stuff here later
    }

    private void DealDamageToPlayer(int damage) {
        currentHitPoints -= damage;
        if(currentHitPoints <= 0) {
            currentHitPoints = maxLife;
            ReduceHearts();
        }
        BecomeInvulnerable();
    }

    public void BecomeInvulnerable() {
        InvulnerabilityTimer = InvulnerabilityTimerMax;
    }

}
