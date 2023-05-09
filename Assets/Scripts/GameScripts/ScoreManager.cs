using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text moneyText;

    int score = 0;
    int money = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        moneyText.text = "Currency: " + money.ToString();
    }

    public void AddPoints()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddMoney()
    {
        money += 5;
        moneyText.text = "Currency: " + money.ToString();
    }
}
