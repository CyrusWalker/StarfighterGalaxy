using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelUnlockSystem
{
    public class LevelSystemManager : MonoBehaviour
    {
        private static LevelSystemManager managerInstance;

        [SerializeField] private LevelData levelData;

        private int currentLevel;
        public int CurrentLevel
        {
            get => currentLevel;
            set => currentLevel = value;
        }
        public static LevelSystemManager ManagerInstance
        {
            get => managerInstance;
        }
        public LevelData LevelData
        {
            get => levelData;
        }

        private void Awake()
        {
            if (managerInstance == null)
            {
                managerInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SaveLoadLevelData.Instance.SaveData();
            }
        }

        private void OnEnable()
        {
            SaveLoadLevelData.Instance.Initialize();
        }
    }
    
    [System.Serializable]
    public class LevelData
    {
        public int lastUnlockedLevel = 0;
        public LevelItem[] levelItems;
    }
    
    [System.Serializable]
    public class LevelItem
    {
        public bool unlocked;
        
    }
}

