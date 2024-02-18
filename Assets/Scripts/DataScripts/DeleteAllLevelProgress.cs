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
        PlayerPrefs.DeleteKey("bulletDamage");
        PlayerPrefs.DeleteKey("money");
        PlayerPrefs.DeleteKey("endlessMode");
        Debug.Log("Level Progress and Upgrades Deleted");
    }
}
