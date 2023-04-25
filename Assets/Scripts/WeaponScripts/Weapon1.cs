using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    public Transform firePoint1;
    public GameObject bulletPrefab;

    public void Shoot()
    { 
        if (gameObject.activeSelf)
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
    }
}
