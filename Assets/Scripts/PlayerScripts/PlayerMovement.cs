using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick Joystick;
    public float moveSpeed;
    Vector2 movementDirection;
    Rigidbody2D playerBody;

    public static bool PointerDown = false;

    void Start(){
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move.x = Joystick.Horizontal;
        //move.y = Joystick.Vertical;
        movementDirection = new Vector2(Joystick.Horizontal, Joystick.Vertical);

    }

    void FixedUpdate(){
        if(PointerDown) {
            playerBody.velocity = Vector3.zero;
        }
        else{
            playerBody.MovePosition(playerBody.position + movementDirection * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
