using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthFrontSizer : MonoBehaviour
{
    [SerializeField] private Image barScale;
    // Start is called before the first frame update
    void Start()
    {
        barScale.fillAmount = 1;
    }

    public void ResizeBar(float verticalScale) {
        Debug.Log("verticalScale is: " + verticalScale);
        barScale.fillAmount = verticalScale;
    }
}
