using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideWithEnemy : MonoBehaviour
{
    public PlayerHealthScript playerHealth;

    void OnTriggerEnter2D(Collider2D collidee) {
        if(collidee.gameObject.tag == "Enemy") {
            if(playerHealth.InvulnerabilityTimer <= 0) {
                Destroy(collidee.gameObject);
            }
            playerHealth.TakeDamage(100);
        }
    }
}
