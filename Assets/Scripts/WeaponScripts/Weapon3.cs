using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon3 : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bulletPrefab;

    public void Shoot()
    {
        if (gameObject.activeSelf)
        {
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        }
    }
}
