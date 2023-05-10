using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        int highscore = PlayerPrefs.GetInt("highscore");
        score += 5;
        scoreText.text = "Score: " + score.ToString();
        if (score > highscore)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void AddMoney()
    {
        money += 10;
        moneyText.text = "Currency: " + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }
}
