using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button ShootButton;

    public void PauseGame()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            ShootButton.enabled = true;
        }

        else
        {
            Time.timeScale = 0;
            ShootButton.enabled = false;
        }
    }

}
