using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Data dataController;
    [SerializeField] public Slider slider;
  
    
    public void OnClick()
    {
        dataController.AddMoney(dataController.GetClickMoney());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Button()
    {
        if(slider.value != 100)
        {
            slider.value += 2;
        }
    }
    
}
