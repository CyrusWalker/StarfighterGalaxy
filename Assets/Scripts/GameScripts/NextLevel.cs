using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    public void MoveToNextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        Debug.Log("The build index for the current scene is " + currentScene.buildIndex);
        int nextSceneIndex = currentScene.buildIndex + 1;

        Scene nextScene = SceneManager.GetSceneByBuildIndex(nextSceneIndex);

        Debug.Log("The build index for the next scene is " + nextSceneIndex);

        if(currentScene.buildIndex != nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);  
            StartCoroutine(SetActive(nextScene));
        }
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
