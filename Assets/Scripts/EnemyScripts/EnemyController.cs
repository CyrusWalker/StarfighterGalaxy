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
        speedX = Random.Range(.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //enemyBody.position = Vector3.Lerp(pointA, pointB, time);
        float time = Mathf.PingPong(Time.time * speedX, 1);
        
        if (transform.position.y > yVal)
        {
            enemyBody.position = new Vector3(Mathf.SmoothStep(-35, 35, time), transform.position.y, 0);
        }
        else
        {
            enemyBody.position = new Vector3(Mathf.SmoothStep(-35, 35, time), yVal, 0); 
            //-35 and 35 are the sides of the screen
        }
        
    }
/*
    private void OnTriggerEnter2D(Collider2D other)
    {
        speedX = -speedX;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speedX = -speedX;
    }
*/


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
