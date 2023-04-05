using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        menuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }
    
    public void ShowMenuPanel()
    {
        menuPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }
    
}
