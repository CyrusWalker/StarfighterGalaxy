using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public bool pierce = false;

    void Start()
    {
        weapon2.SetActive(false);
        weapon3.SetActive(false);
    }

    void Weapon2()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(true);
        weapon3.SetActive(false);
    }

    void Weapon3()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        weapon3.SetActive(true);
    }

    public void ArmorPierceTrue()
    {
        pierce = true;
    }
}
