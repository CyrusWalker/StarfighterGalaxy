using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    private Camera cam; 
    private Rigidbody2D enemyBody;
    public float speedY = 1f;
    public float speedX = 1f;
    public int yValMin;
    public int yValMax;
    private int yVal;

    // Start is called before the first frame update
    void Start()
    {
        yVal = Random.Range(yValMin,yValMax);
        enemyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y > yVal)
        {
            enemyBody.velocity = new Vector2(speedX, -speedY);
        }
        else
        {
            enemyBody.velocity = new Vector2(speedX, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        speedX = -speedX;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speedX = -speedX;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
