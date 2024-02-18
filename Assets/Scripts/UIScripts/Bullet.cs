using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D bulletBody;
    [SerializeField] public int bulletDamage; //DO NOT SET IN THE EDITOR
    [SerializeField] private EnemyHealth enemy;
    [SerializeField] private WeaponSelect playerWeapon;

    // Start is called before the first frame update
    void Awake() 
    {
        playerWeapon = GameObject.Find("Player 1").GetComponent<WeaponSelect>();
    }

    void Start()
    {
        Debug.Log("called Start() on Bullet Object");
        Debug.Log("Bullet damage from key is: " + playerWeapon.bulletDamage);
        bulletDamage = playerWeapon.bulletDamage;
        bulletBody.velocity = transform.up * speed;
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        bool pierce = GameObject.Find("Player 1").GetComponent<WeaponSelect>().pierce;
        if(collider.gameObject.tag == "Enemy") {
            enemy = collider.gameObject.GetComponent<EnemyHealth>();
            enemy.TakeDamage(bulletDamage);
            if (pierce == false)
                Destroy(gameObject);
        }
    }

    public void SetDamage(int damage) {
        bulletDamage = damage;
    }

    public int GetDamage() {
        return bulletDamage;
    }
}
