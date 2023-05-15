using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllLevelProgress : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.DeleteKey("levelAt");
        PlayerPrefs.DeleteKey("numberOfHearts");
        PlayerPrefs.DeleteKey("numberOfBullets");
        PlayerPrefs.DeleteKey("armorPiercing");
        PlayerPrefs.DeleteKey("maxHealth");
        PlayerPrefs.DeleteKey("fireRate");
        PlayerPrefs.DeleteKey("money");
        Debug.Log("Level Progress and Upgrades Deleted");
    }
}
