using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public TMP_Text gameTimerText;
    private string minutes;
    private string seconds;
    public bool levelEnded;

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        if (levelEnded == false) {
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("00");
            gameTimerText.text = "Time: " + minutes + ":" + seconds;
        }
    }

}
