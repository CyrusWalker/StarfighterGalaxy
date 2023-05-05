using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bulletBody;

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
            Destroy(collider.gameObject);
            if (pierce == false)
                Destroy(gameObject);
        }

    }
}
