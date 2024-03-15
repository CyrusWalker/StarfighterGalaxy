using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bulletPrefab;
    
    public AudioSource shootSFX;

    public void Shoot()
    {
        if (gameObject.activeSelf)
        {
            if (shootSFX != null)
                shootSFX.Play();
            Instantiate(bulletPrefab, firePoint2.position, firePoint3.rotation);
            Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        }
    }
}
