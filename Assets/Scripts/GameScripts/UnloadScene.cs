using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnloadScene : MonoBehaviour
{
    public void LeaveScene()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
