using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllLevelProgress : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.DeleteKey("levelAt");
        Debug.Log("Level Progress Deleted");
    }
}
