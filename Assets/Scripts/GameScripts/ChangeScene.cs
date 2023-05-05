using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // public float delay;
    
    public int sceneID;
    public void MoveToScene()
    {
        // string levelName = "Level" + sceneID;
        Debug.Log("Scene ID is: " + sceneID);
        // sceneID = PlayerPrefs.GetInt(levelName);
        Scene nextScene = SceneManager.GetSceneByBuildIndex(sceneID);
        SceneManager.LoadScene(sceneID); 
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
