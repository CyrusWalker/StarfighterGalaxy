using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonID : MonoBehaviour
{
    public int sceneID;
    private string levelName;
    // Start is called before the first frame update
    void Awake()
    {
        levelName = "Level" + sceneID;
        
        SaveLevelID(levelName, sceneID);
    }

    void Update()
    {
        SaveLevelID(levelName, sceneID);
    }

    void SaveLevelID(string levelName, int sceneID)
    {
        PlayerPrefs.SetInt(levelName, sceneID);
    }

}
