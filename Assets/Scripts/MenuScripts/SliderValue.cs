using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider slider;
    public GameObject NoVolume;


    // Update is called once per frame
    void Update()
    {
        ChangeSliderValue();
    }

    void ChangeSliderValue()
    {
        if(slider.value < 1)
        {
            NoVolume.SetActive(true);
        }
    }

}
