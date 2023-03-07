using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public enum FirePointNumber
    {
        One,
        Two,
        Three
    };

    public FirePointNumber FirePointNum;
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    { 
        
        if (FirePointNum.ToString() == "One")
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);

        else if (FirePointNum.ToString() == "Two") {
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        }
        else if (FirePointNum.ToString() == "Three") {
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        }

    }
}
