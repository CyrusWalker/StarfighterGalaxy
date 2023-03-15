using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Camera cam; 
    private Rigidbody2D rb;
    public float speedY = 1f;
    public float speedX = 1f;

    private float halfScreen = (Screen.height / 2.0f);
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.x < cam.transform.position.x)
        // {
        //     if (transform.position.y > halfScreen)
        //     {
        //         rb.velocity = new Vector2(speedX, -speedY);
        //     }
        //     else
        //     {
        //         rb.velocity = new Vector2(speedX, 0f);
        //     }
        // }
        // else
        // {
        //     speedX = -speedX;
        // }
        
        rb.velocity = new Vector2(speedX, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        speedX = -speedX;
    }
}
