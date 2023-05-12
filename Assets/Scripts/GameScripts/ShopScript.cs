using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{
    public static ShopScript instance;

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

    public void Purchase(int amount)
    {
        if(money > amount)
        {
            money -= amount;
            PlayerPrefs.SetInt("money", money);
            moneyText.text = "Money: \n$" + money.ToString(); 
        }
    }

    
}
