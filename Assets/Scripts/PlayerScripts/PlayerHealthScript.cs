using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public GameManager gameManager;
    public int maxHitPoints = 100;
    public double currentHitPoints;
    public HeartManagerScript hearts;
    [SerializeField] private float InvulnerabilityTimerMax;
    public float InvulnerabilityTimer;
    public HealthFrontSizer healthBar;
    public Animator anim;
    public Button PauseButton;
    public AudioSource hitSound;
    private const string MAX_HEALTH_KEY = "maxHealth";

    void Awake()
    {
        maxHitPoints = PlayerPrefs.GetInt(MAX_HEALTH_KEY, 100);
    }

    // Start is called before the first frame update
    void Start() {
        currentHitPoints = maxHitPoints;
    }
    
    void Update() {
        if(InvulnerabilityTimer > 0) {
            InvulnerabilityTimer -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damage) {
        if(InvulnerabilityTimer <= 0) {
            DealDamageToPlayer(damage);
            hitSound.Play();
        }
    }

    void ReduceHearts() {
        hearts.ReduceHearts();
        if(hearts.GetHearts() <= 0) {
            Die();
        }
    }
    
    void Die() {
        gameManager.Pause();
        anim.SetTrigger("Show");
        GameObject settingsPanel = GameObject.Find("SettingsPanel");
        settingsPanel.SetActive(false);
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

    public void IncreaseMaxHealth()
    {
        int tempmax = maxHitPoints;
        maxHitPoints += 50;
        currentHitPoints = currentHitPoints / tempmax * maxHitPoints;
    }

    public int HealthToScore()
    {
        int score = (int)currentHitPoints / maxHitPoints * 10;
        return score;
    }
}
