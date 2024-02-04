using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D bulletBody;
    [SerializeField] public int bulletDamage; //DO NOT SET IN THE EDITOR
    [SerializeField] private EnemyHealth enemy;
    private const string BULLET_DAMAGE_KEY = "bulletDamage";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("called Start() on Bullet Object");
        Debug.Log("Bullet damage from key is: " + PlayerPrefs.GetInt(BULLET_DAMAGE_KEY));
        bulletDamage = PlayerPrefs.GetInt(BULLET_DAMAGE_KEY, 40);
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
