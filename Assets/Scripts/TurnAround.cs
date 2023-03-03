using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    private bool collision = false;
    private Rigidbody2D body2D;
    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == Screen.width || transform.position.x == Screen.height) {
            collision = true;
        } else {
            collision = false;
        }
        if(collision) {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1,1 );
        }
    }
}
