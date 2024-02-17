using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{
    public static ShopScript instance;
    [SerializeField] private UpgradeShopScript upgrades;

    public TMP_Text moneyText;

    int money = 0;

    private void Awake()
    {
        money = PlayerPrefs.GetInt("money");
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Money: \n$" + money.ToString(); 
    }

    public void Purchase(int upgrade)
    {
        if(money >= 100)
        {
            money -= 100;
            PlayerPrefs.SetInt("money", money);
            moneyText.text = "Money: \n$" + money.ToString();

            if(upgrade == 1) {
                upgrades.UpgradeAddHeart();
            } else if (upgrade == 2) {
                upgrades.UpgradeTwoBullets();
            } else if (upgrade == 3) {
                upgrades.UpgradeThreeBullets();
            } else if (upgrade == 4) {
                upgrades.UpgradeArmorPiercing();
            } else if (upgrade == 5) {
                upgrades.UpgradeHealth();
            } else if (upgrade == 6) {
                upgrades.UpgradeBulletDamage();
            } else {
                Debug.Log("BAD UPGRADE PARAMETER");
            }
        }
    }

    public void AddMoney()
    {
        money += 100;
    }

    
}
