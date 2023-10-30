using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    public TMP_Text moneyText;
    int money = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        moneyText.text = "Currency: " + money.ToString();
    }
    public void AddMoney()
    {
        money += 10;
        moneyText.text = "Currency: " + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }
}
