using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEvent : MonoBehaviour
{
    public Slider sinsaPower;
    public float maxPower = 0.0f;
    public float minusPower = 0.0f;
    private float time = 0.0f;
    public float sValue = 0.0f;

    void Start(){
        
    }

    void sinsaTimes(){
        Debug.Log ("신사타임 시작!");
        sValue = sinsaPower.value;
    }

    void Update(){
        sinsaPower.value -= minusPower * Time.deltaTime;

        if (sValue > 99.9)
        {
            sinsaTimes();
        }
    }
}

