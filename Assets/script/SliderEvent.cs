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
    public float fTime = 0.0f;
    public float fLimitTime = 0.0f;
    public int times = 0;

    void Start(){
        
    }

    void Update(){
        sinsaPower.value -= minusPower * Time.deltaTime;
        sValue = sinsaPower.value;
        times = dataController.GetSinsaTime();
        if (sValue > 99.9)
        {
            Debug.Log ("신사타임 시작!");
            fTime += Time.deltaTime;
            if(fTime >= fLimitTime)
            {
                sinsaPower.value = 100;
                return;
            }
        }
    }
}

