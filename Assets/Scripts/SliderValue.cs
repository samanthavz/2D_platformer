using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI sliderText;

    void Update()
    {
        sliderText.text = slider.value.ToString();

    }
   
}
