using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SliderEvent : MonoBehaviour
{
    public Slider sinsaPower;
    public Data dataController;
    public float maxPower = 0.0f;
    public float minusPower = 0.0f;
    public float sValue = 0.0f;

    void Start(){
        
    }

    void sinsaTimes(){
        Debug.Log ("신사타임 시작!");
    }

    void Update(){
        sinsaPower.value -= minusPower * Time.deltaTime;
        sValue = sinsaPower.value;

        if (sValue > 99.9)
        {
            sinsaTimes();
        }
    }
}

