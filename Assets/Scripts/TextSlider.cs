using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public Slider slider;

    public void SetNumberText()
    {
        
        numberText.text = slider.value.ToString();
    }
}
