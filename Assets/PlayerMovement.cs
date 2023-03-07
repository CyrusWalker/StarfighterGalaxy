using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick Joystick;
    public float moveSpeed;
    Vector2 move;
    Rigidbody2D rb;

    public static bool PointerDown = false;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;

    }

    void FixedUpdate(){
        if(PointerDown) {
            rb.velocity = Vector3.zero;
        }
        else{
            rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
