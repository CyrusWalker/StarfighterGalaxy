using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public HeartManagerScript hms;
    public PlayerHealthScript phs;
    public TMP_Text scoreText;
    int score = 0;



    private void Awake()
    {
        instance = this;
    }

    public void SetScore()
    {
        score = (10 * hms.GetHearts()) + phs.HealthToScore() + 99 - (int)Time.time;
        scoreText.text = "Score: " + score.ToString();
    }

}
