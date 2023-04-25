using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject heart1; //DO NOT SET THESE IN THE INSPECTOR
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    [SerializeField] private GameObject heart4;
    [SerializeField] private GameObject heart5;
    [SerializeField] private int heartCount;
    private GameObject[] hearts;
    // Start is called before the first frame update
    void Awake()
    {
        heart1 = gameObject.transform.GetChild(0).gameObject;
        heart1.SetActive(true);
        heart2 = gameObject.transform.GetChild(1).gameObject;
        heart2.SetActive(true);
        heart3 = gameObject.transform.GetChild(2).gameObject;
        heart3.SetActive(true);
        heart4 = gameObject.transform.GetChild(3).gameObject;
        heart4.SetActive(false);
        heart5 = gameObject.transform.GetChild(4).gameObject;
        heart5.SetActive(false);
    }

    void Start()
    {
        
        hearts = new GameObject[5]{heart1, heart2, heart3, heart4, heart5};
        heartCount = 3;
    }

    public void ReduceHearts() {
        hearts[heartCount - 1].SetActive(false);
        heartCount--;
        
    }

    public void AddHeart() {
        if(heartCount == 5) {
            Debug.Log("Attempted to add a heart when the player already has 5");
        } else {
            hearts[heartCount].SetActive(true);
            heartCount++;
        }
    }

    public int GetHearts() {
        return heartCount;
    }
    
}
