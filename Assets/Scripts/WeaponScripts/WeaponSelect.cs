using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public bool pierce = false;
    public int gunCount;
    public int bulletDamage;
    private const string ARMOR_PIERCING_KEY = "armorPiercing";
    private const string WEAPONS_ARRAY_KEY = "numberOfBullets";
    private const string BULLET_DAMAGE_KEY = "bulletDamage";

    void Awake()
    {
        pierce = Convert.ToBoolean(PlayerPrefs.GetInt(ARMOR_PIERCING_KEY, Convert.ToInt32(false)));
        gunCount = PlayerPrefs.GetInt(WEAPONS_ARRAY_KEY, 1);
        bulletDamage = PlayerPrefs.GetInt(BULLET_DAMAGE_KEY, 40);
        Debug.Log("Weapon Select Bullet damge is: " + bulletDamage);
    }

    void Start()
    {
        if(gunCount == 2) {
            Weapon2();
        } else if (gunCount == 3) {
            Weapon3();
        } else {
            Weapon1();
        }
    }

    public void Weapon1()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
        weapon3.SetActive(false);
    }

    public void Weapon2()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(true);
        weapon3.SetActive(false);
    }

    public void Weapon3()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        weapon3.SetActive(true);
    }

    public void ArmorPierceTrue()
    {
        pierce = true;
    }

    public int GetBulletDamage() {
        return bulletDamage;
    }
    
    public void SetBulletDamage(int damage) {
        bulletDamage = damage;
    }
}
