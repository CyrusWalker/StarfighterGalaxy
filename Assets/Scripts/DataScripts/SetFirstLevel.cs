using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFirstLevel : MonoBehaviour
{
    public int firstLevelIndex;
    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.GetInt("firstLevelIndex").CompareTo(firstLevelIndex) != 0)
        {
            PlayerPrefs.SetInt("firstLevelIndex", firstLevelIndex);
        }
    }

}
