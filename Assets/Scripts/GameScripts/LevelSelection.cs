using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons;
    // Start is called before the first frame update
    public int firstLevelIndex;
    void Start()
    {
        if (PlayerPrefs.GetInt("firstLevelIndex").CompareTo(firstLevelIndex) != 0)
        {
            PlayerPrefs.SetInt("firstLevelIndex", firstLevelIndex);
        }
        
        int levelAt = PlayerPrefs.GetInt("levelAt", firstLevelIndex);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + firstLevelIndex > levelAt)
            {
                levelButtons[i].interactable = false;
            }
        }
    }
}
