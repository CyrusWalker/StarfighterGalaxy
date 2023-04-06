using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public GameManager gameManager;
    public int maxHitPoints = 100;
    public int currentHitPoints;
    public int hearts = 3;
    [SerializeField] private float InvulnerabilityTimerMax;
    public float InvulnerabilityTimer;
    public HealthFrontSizer healthBar;
    public Animator anim;
    public Button PauseButton;

    // Start is called before the first frame update
    void Start() {
        currentHitPoints = maxHitPoints;
        //anim = GetComponent<Animator>();
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
        gameManager.Pause();
        anim.SetTrigger("Show");
        PauseButton.enabled = false;
    }

    private void DealDamageToPlayer(int damage) {
        currentHitPoints -= damage;
        if(currentHitPoints <= 0) {
            currentHitPoints = maxHitPoints;
            ReduceHearts();
        }
        float newSize = (float) currentHitPoints / maxHitPoints;
        healthBar.ResizeBar(newSize);
        BecomeInvulnerable();
    }

    public void BecomeInvulnerable() {
        InvulnerabilityTimer = InvulnerabilityTimerMax;
    }

}
