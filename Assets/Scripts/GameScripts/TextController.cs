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
    [SerializeField] private float speechSpeed;
    private IEnumerator coroutine;

    // Start is called before the first frame update
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
            displayText.text += dialogue[i];
            yield return new WaitForSeconds(speechSpeed);
        }
        
        yield return null;
    }
}
