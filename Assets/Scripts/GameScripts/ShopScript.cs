using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopScript : MonoBehaviour
{
    public static ShopScript instance;
    [SerializeField] private UpgradeShopScript upgrades;

    public TMP_Text moneyText;

    int money = 0;
    public Button purchaseButton;
    public TMP_Text purchaseText;
    public string currentPrice;
    int bulletStatus = 1;

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
            ShopButton();
            money -= 100;
            PlayerPrefs.SetInt("money", money);
            moneyText.text = "Money: \n$" + money.ToString();

            if(upgrade == 1) 
            {
                upgrades.UpgradeAddHeart();
            } else if (upgrade == 2)
            {
                if (bulletStatus == 1)
                {
                    upgrades.UpgradeTwoBullets();
                    bulletStatus = 2;
                } else if (bulletStatus == 2)
                {
                    upgrades.UpgradeThreeBullets();
                    bulletStatus = 3;
                }
            } else if (upgrade == 3)
            {
                upgrades.UpgradeArmorPiercing();
            } else if (upgrade == 4)
            {
                upgrades.UpgradeHealth();
            } else if (upgrade == 5)
            {
                upgrades.UpgradeBulletDamage();
            } else {
                Debug.Log("BAD UPGRADE PARAMETER");
            }
        }
    }

    public void ShopButton()
    {
        StartCoroutine(TimeoutButton());
    }

    IEnumerator TimeoutButton()
    {        
        currentPrice = purchaseText.text;
        purchaseText.text = "Purchased";
        purchaseButton.interactable = false;
        yield return new WaitForSeconds(.5f);
        purchaseButton.interactable = true;
        purchaseText.text = currentPrice;
    }
    
}
