using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class TextController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayText;
    [SerializeField] private String dialogue;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Awake()
    {
        dialogue = "This is a test string, it should print character-by-character.";
    }
    
    void Start()
    {
        coroutine = RevealTextSlowly(displayText, dialogue);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RevealTextSlowly(TextMeshProUGUI displayText, String dialogue)
    {
        for(int i = 0; i < dialogue.Length; i++) {
            yield return displayText.text += dialogue[i];
            yield return new WaitForSeconds(0.01f);
        }
        
        yield return null;
    }
}
