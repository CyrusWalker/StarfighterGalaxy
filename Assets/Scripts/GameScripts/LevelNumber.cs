using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public int sceneID;
    // Start is called before the first frame update
    void Start()
    {
        string levelName = "Level" + sceneID;
        int firstLevelIndex = PlayerPrefs.GetInt("firstLevelIndex");
        int levelNumber = (PlayerPrefs.GetInt(levelName) - firstLevelIndex) + 1;
        levelText.text = levelNumber.ToString();
    }
}
