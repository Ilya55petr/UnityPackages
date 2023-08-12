using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthLevel : MonoBehaviour
{

    public int healthLevel;
    public Slider mySlider;
    public Image myImage;
    
    
    void Update()
    {
        if (mySlider.value < 10)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }
        
        
        mySlider.value = healthLevel;
    }
}
