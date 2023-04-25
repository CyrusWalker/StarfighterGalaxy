using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // public float delay;
    
    public void MoveToScene(int sceneID)
    {
        var nextScene = SceneManager.GetSceneByBuildIndex(sceneID);
        var oldScene = SceneManager.GetActiveScene();
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
