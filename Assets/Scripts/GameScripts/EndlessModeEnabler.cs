using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndlessModeEnabler : MonoBehaviour
{
    public Button endlessModeButton;
    public bool endlessModeDevToggle;
    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.HasKey("endlessMode"))
        {
            // Get the flag for endless mode and convert it from an integer back to a boolean
            endlessModeDevToggle = Convert.ToBoolean(PlayerPrefs.GetInt("endlessMode"));
            SetEndlessMode(endlessModeDevToggle);
        }
        else
        {
            // There isn't a SetBool in player prefs, so we need to convert it to an integer before storage
            PlayerPrefs.SetInt("endlessMode", Convert.ToInt32(endlessModeDevToggle));
            SetEndlessMode(endlessModeDevToggle);
        }

    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("endlessMode"))
        {
            endlessModeDevToggle = Convert.ToBoolean(PlayerPrefs.GetInt("endlessMode"));
            SetEndlessMode(endlessModeDevToggle);
        }
    }

    private void SetEndlessMode(bool enabled)
    {
        endlessModeButton.interactable = enabled;
    }
}
