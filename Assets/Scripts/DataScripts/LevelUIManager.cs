using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace LevelUnlockSystem
{
    public class LevelUIManager : MonoBehaviour
    {
        [SerializeField] private GameObject levelButtonGrid;
        [SerializeField] private LevelButton levelButtonPrefab;

        private void Start()
        {
            InitializeUI();
        }

        public void InitializeUI()
        {

            LevelItem[] LevelItems = LevelSystemManager.ManagerInstance.LevelData.levelItems;
            for (int i = 0; i < LevelItems.Length; i++)
            {
                LevelButton levelButton = Instantiate(levelButtonPrefab, levelButtonGrid.transform);
                levelButton.SetLevelButton(LevelItems[i], i, i == LevelSystemManager.ManagerInstance.LevelData.lastUnlockedLevel);
            }
        }
    }
}
