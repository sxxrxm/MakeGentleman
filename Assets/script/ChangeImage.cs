using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangeImage : MonoBehaviour
{
    public Image TestIm0; //기존에 존제하는 이미지
    public Sprite Im1; //바뀌어질 이미지
    public Data dataController;
    public int i;
    public int[] prices = {500, 16000, 40000, 100000};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dataController.GetMoney()>=prices[i]){
            TestIm0.sprite = Im1;
        }
    }
}
