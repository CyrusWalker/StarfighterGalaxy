using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button ShootButton;
    public Button PauseButton;
    public FixedJoystick Joystick;
    public GameObject spawner;
    private EnemySpawner EnemySpawner;
    public GameObject WinPanel;
    public float TimeScale;
    bool levelEnded = false;

    public void Start()
    {
        EnemySpawner = spawner.GetComponent<EnemySpawner>();
    }

    public void Update()
    {
        this.TimeScale = Time.timeScale;

        var enemies = GameObject.FindWithTag("Enemy");
        if (enemies == null && EnemySpawner.spawnCount == EnemySpawner.spawnMax)
        {
            if (levelEnded == false)
            {
                EndLevel();
            }
        }
    }


    public void EndLevel()
    {
        levelEnded = true;
        WinPanel.SetActive(true);
        PauseButton.enabled = false;
        ShootButton.enabled = false;
        Joystick.enabled = false;
    }

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
