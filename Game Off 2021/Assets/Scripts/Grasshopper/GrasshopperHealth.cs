using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrasshopperHealth : MonoBehaviour
{
    //grasshopper's health, thanks to Brackey's yt tutorial

    public Slider slider;

    public void SetMaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    
}
