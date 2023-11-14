using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShopScript : MonoBehaviour
{
    [SerializeField] private PlayerHealthScript playerHealth;
    [SerializeField] private Bullet playerBullet;
    [SerializeField] private WeaponSelect playerWeapons;
    [SerializeField] private HeartManagerScript playerHearts;
    private const string MAX_HEALTH_KEY = "maxHealth";
    private const string BULLET_DAMAGE_KEY = "bulletDamage";
    private const string ARMOR_PIERCING_KEY = "armorPiercing";
    private const string WEAPONS_ARRAY_KEY = "numberOfBullets";
    private const string HEART_COUNT_KEY = "numberOfHearts";
    public void UpgradeHealth() {
        playerHealth.IncreaseMaxHealth();
        PlayerPrefs.SetInt(MAX_HEALTH_KEY, playerHealth.maxHitPoints);
    }

    public void UpgradeBulletDamage() {
        playerBullet.SetDamage(playerBullet.GetDamage() + 10);
        PlayerPrefs.SetFloat(BULLET_DAMAGE_KEY, playerBullet.GetDamage());
    }

    public void UpgradeArmorPiercing() {
        playerWeapons.ArmorPierceTrue();
        PlayerPrefs.SetInt(ARMOR_PIERCING_KEY, Convert.ToInt32(true));
    }

    public void UpgradeTwoBullets() {
        playerWeapons.Weapon2();
        PlayerPrefs.SetInt(WEAPONS_ARRAY_KEY, 2);
    }

    public void UpgradeThreeBullets() {
        playerWeapons.Weapon3();
        PlayerPrefs.SetInt(WEAPONS_ARRAY_KEY, 3);
    }

    public void UpgradeAddHeart() {
        playerHearts.AddHeart();
        PlayerPrefs.SetInt(HEART_COUNT_KEY, playerHearts.GetHearts());
    }
}
