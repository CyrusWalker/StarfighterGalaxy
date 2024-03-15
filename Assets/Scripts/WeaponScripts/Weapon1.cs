using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    public Transform firePoint1;
    public GameObject bulletPrefab;
    public AudioSource shootSFX;

    public void Shoot()
    {
        if (gameObject.activeSelf)
        {
            if (shootSFX != null)
                shootSFX.Play();
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        }
    }
}
