using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
  [SerializeField] private AudioMixer mixer;
  [SerializeField] private Slider masterSlider;
  [SerializeField] private Slider musicSlider;
  [SerializeField] private Slider sfxSlider;

  public const string MIXER_MASTER = "MasterVolume";
  public const string MIXER_MUSIC = "MusicVolume";
  public const string MIXER_SFX = "SFXVolume";

  private void Awake()
  {
    masterSlider.onValueChanged.AddListener(SetMasterVolume);
    musicSlider.onValueChanged.AddListener(SetMusicVolume);
    sfxSlider.onValueChanged.AddListener(SetSFXVolume);
  }

  private void Start()
  {
    masterSlider.value = PlayerPrefs.GetFloat(AudioManager.MASTER_KEY, 1f);
    musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
    sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFX_KEY, 1f);
  }

  private void OnDisable()
  {
    PlayerPrefs.SetFloat(AudioManager.MASTER_KEY, masterSlider.value);
    PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
    PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);
  }

  // Volumes is logarithmic rather than linear,
  // so we need a logarithmic function with an offset to update the mixer properly
  
  // Volume will break if set to 0 because it works on a Logarithmic curve,
  // so the Min value on the sliders must be set to a really
  // small value instead of 0.
  void SetMasterVolume(float volume)
  {
    mixer.SetFloat(MIXER_MASTER, Mathf.Log10(volume) * 20);
  }
  void SetMusicVolume(float volume)
  {
    mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volume) * 20);
  }
  void SetSFXVolume(float volume)
  {
    mixer.SetFloat(MIXER_SFX, Mathf.Log10(volume) * 20);
  }
}
