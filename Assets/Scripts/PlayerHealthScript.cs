using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeScript : MonoBehaviour
{
    public float maxLife = 100;
    public float hitPoints;
    public int hearts = 3;
    // Start is called before the first frame update
    void Start() {
        hitPoints = maxLife;
    }

    void Damage(float dmg) {
        hitPoints -= dmg;
        if(hitPoints <= 0) {
            hitPoints = maxLife;
            ReduceHearts();
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
}
