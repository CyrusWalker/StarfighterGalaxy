using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Kill() {
        Destroy(gameObject);
    }

    /*void Update() {
        if(Input.GetKeyDown("space")) {
            Kill();
        }
    }*/
}
