using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LevelUnlockSystem
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private GameObject lockObject, unlockObject;
        [SerializeField] private TextMeshProUGUI levelIndexText;
        [SerializeField] private Color lockColor, unlockColor;
        [SerializeField] private Button button;

        public bool levelUnlocked;
        // [SerializeField] private GameObject activeLevelIndicator;

        private int levelIndex;

        private void Start()
        {
            button.onClick.AddListener(() => OnClick());
        }

        private void ChangeLevelButton(LevelItem value)
        {
            value.unlocked = levelUnlocked;
        }

        private void Update()
        {
            levelIndexText.text = levelIndex.ToString();
        }

        public void SetLevelButton(LevelItem value, int index, bool activeLevel)
        {
            if (value.unlocked)
            {
                // activeLevelIndicator.SetActive(activeLevel);
                levelIndex = index + 1;
                button.interactable = true;
                lockObject.SetActive(false);
                unlockObject.SetActive(true);
                levelIndexText.text = "" + levelIndex;
            }
            else
            {
                button.interactable = false;
                lockObject.SetActive(true);
                unlockObject.SetActive(false);
            }
        }
        
        private void OnClick()
        {
            LevelSystemManager.ManagerInstance.CurrentLevel = levelIndex - 1;
            SceneManager.LoadScene("Level" + levelIndex);
        }
    }
    
    
}

