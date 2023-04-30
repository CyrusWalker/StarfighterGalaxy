using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    
    private int weaponSelect = 1;

    void Start()
    {
        weapon2.SetActive(false);
        weapon3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (weaponSelect == 3)
            {
                weapon1.SetActive(true);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                weaponSelect = 1;
            }
            else if (weaponSelect == 2)
            {
                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(true);
                weaponSelect = 3;
            }
            else if (weaponSelect == 1)
            {
                weapon1.SetActive(false);
                weapon2.SetActive(true);
                weapon3.SetActive(false);
                weaponSelect = 2;
            }
        }
    }
}
