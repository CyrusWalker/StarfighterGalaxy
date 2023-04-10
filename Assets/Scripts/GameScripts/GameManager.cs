using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button ShootButton;
 

    public void Pause()
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

    public void ResetLevel()
    {
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
