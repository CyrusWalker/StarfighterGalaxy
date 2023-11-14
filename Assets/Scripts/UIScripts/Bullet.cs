using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bulletBody;
    public int bulletDamage = 33;
    [SerializeField] private EnemyHealth enemy;

    // Start is called before the first frame update
    void Start()
    {
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
            MoneyManager.instance.AddMoney();
        }
    }

    public void SetDamage(int damage) {
        bulletDamage = damage;
    }

    public int GetDamage() {
        return bulletDamage;
    }
}
