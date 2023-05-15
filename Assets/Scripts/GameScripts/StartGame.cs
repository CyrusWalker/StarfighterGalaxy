using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private AudioManager audioManager;
    public void BeginGame()
    {
        int sceneID = PlayerPrefs.GetInt("firstLevelIndex");
        Debug.Log("Scene ID is: " + sceneID);
        // sceneID = PlayerPrefs.GetInt(levelName);
        Scene nextScene = SceneManager.GetSceneByBuildIndex(sceneID);
        audioManager = FindObjectOfType<AudioManager>();
        SceneManager.LoadScene(sceneID); 
        audioManager.PlayLevelMusic();
        StartCoroutine(SetActive(nextScene));
    }
    
    public IEnumerator SetActive(Scene scene)
    {
        int i = 0;
        while(i == 0)
        {
            i++;
            yield return null;
        }
        SceneManager.SetActiveScene(scene);
        yield break;
    }
}
