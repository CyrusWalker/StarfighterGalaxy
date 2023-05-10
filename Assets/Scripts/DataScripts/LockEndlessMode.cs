using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockEndlessMode : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.SetInt("endlessMode", Convert.ToInt32(false));
        Debug.Log("Endless Mode Locked");
    }
}
