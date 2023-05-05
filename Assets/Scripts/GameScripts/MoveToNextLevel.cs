using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    private int lastSceneIndex;

    private bool endlessMode;
    // Start is called before the first frame update
    void Start()
    {
        lastSceneIndex = PlayerPrefs.GetInt("finalLevelIndex");
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnClick()
    {
        if (SceneManager.GetActiveScene().buildIndex == lastSceneIndex)
        {
            Debug.Log("YOU WON THE GAME!!!");
            
            endlessMode = true;
            PlayerPrefs.SetInt("endlessMode", Convert.ToInt32(endlessMode));
            Debug.Log("Endless Mode Unlocked!");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }

    }
}
