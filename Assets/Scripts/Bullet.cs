using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void onCollisionEnter(Collision collision) {
        var target = collision.gameObject;
        if(collision.gameObject.tag == "Enemy") {
            Destroy(target);
            Destroy(gameObject);
        }
    }
}
