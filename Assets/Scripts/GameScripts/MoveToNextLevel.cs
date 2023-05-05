using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    private int lastSceneIndex;
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
