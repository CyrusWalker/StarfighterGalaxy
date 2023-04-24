using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    private float currentVolume;

    
    // Start is called before the first frame update
    
    void Start()
    {
        LoadPreferences();
    }
    // Update is called once per frame
    void Update()
    {
        SavePreferences();
    }
    
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }

    public void SavePreferences()
    {
        PlayerPrefs.SetFloat("VolumePreference", currentVolume);
    }

    public void LoadPreferences()
    {
        if (PlayerPrefs.HasKey("VolumePreference"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference");
        }
        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference");
        }
    }
}
