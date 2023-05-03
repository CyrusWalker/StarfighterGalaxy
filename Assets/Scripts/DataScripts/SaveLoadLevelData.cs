using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelUnlockSystem
{
    public class SaveLoadLevelData : MonoBehaviour
    {
        public static SaveLoadLevelData dataInstance;
        
        public static SaveLoadLevelData Instance
        {
            get => dataInstance;
        }

        private void Awake()
        {
            // if the data instance doesn't have any data yet, give it the data of the current instance
            if (dataInstance == null)
            {
                dataInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void Initialize()
        {
            if (PlayerPrefs.GetInt("GameStartedFirstTime") == 1)
            {
                LoadData();
            }
            else
            {
                SaveData();
                PlayerPrefs.SetInt("GameStartedFirstTime", 1);
            }
        }

        public void SaveData()
        {
            string levelDataToString = JsonUtility.ToJson(LevelSystemManager.ManagerInstance.LevelData);

            try
            {
                System.IO.File.WriteAllText(Application.persistentDataPath + "/LevelData.json", levelDataToString);
                Debug.Log("Data Saved!");
            }
            catch (System.Exception e)
            {
                Debug.Log("Error Saving Data " + e);
                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                string levelDataToString = System.IO.File.ReadAllText(Application.persistentDataPath + "/LevelData.json");
                LevelData levelData = JsonUtility.FromJson<LevelData>(levelDataToString);
                if (levelData != null)
                {
                    LevelSystemManager.ManagerInstance.LevelData.levelItems = levelData.levelItems;
                    LevelSystemManager.ManagerInstance.LevelData.lastUnlockedLevel = levelData.lastUnlockedLevel;
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("Error Loading Data " + e);
                throw;
            }
        }
    }
}