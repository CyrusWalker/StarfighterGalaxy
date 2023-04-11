using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = -150f;
    public Rigidbody2D bulletBody;
    [SerializeField] private PlayerHealthScript player;

    // Start is called before the first frame update
    void Start()
    {
        bulletBody.velocity = transform.up * speed;
        Debug.Log("Instantiated EnemyBullet");
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player") {
            player = collider.gameObject.GetComponent<PlayerHealthScript>();
            player.TakeDamage(20);
            Destroy(gameObject);
        }

    }
}
