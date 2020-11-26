using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Data dataController;
    public Upgrade UpUp;
    [SerializeField] public Slider slider;
  
    
    public void OnClick()
    {
        dataController.AddMoney(dataController.GetClickMoney());
    }


    public void Button()
    {
        if(slider.value != 100)
        {
            slider.value += 2;
      }
    }
    
}
