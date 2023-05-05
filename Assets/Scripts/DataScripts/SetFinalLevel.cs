using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFinalLevel : MonoBehaviour
{
    public int finalLevelIndex;
    void Awake()
    {
        PlayerPrefs.SetInt("finalLevelIndex", finalLevelIndex);
    }
}
