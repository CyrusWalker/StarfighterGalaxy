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
    public HeartManagerScript hearts;
    public ScoreManager sm;
    public LevelTimer levelTimer;
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
            if (levelEnded == false && hearts.GetHearts() != 0)
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
        sm.SetScore();
        levelTimer.levelEnded = true;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        ShootButton.enabled = false;
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        ShootButton.enabled = true;
    }

    public void ResetLevel()
    {
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
