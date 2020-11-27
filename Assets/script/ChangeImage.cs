using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangeImage : MonoBehaviour
{
    public Image TestIm0; //기존에 존제하는 이미지
    public Sprite Im1; //바뀌어질 이미지
    public Image coin;
    public Data dataController;
    public int i;
    public int[] prices = {5000, 16000, 40000, 100000};
    public int buy = 0;
    public Text fix;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dataController.GetMoney()>=prices[i]){
            TestIm0.sprite = Im1;
            if(buy == 0){
                buy = 1;
            }
        }
    }
    public void buyStore(){
        if(buy == 1){
            dataController.SubMoney(prices[i]);
            fix.GetComponent<Text>().text= "보유 중";
            Destroy(coin);
            if(i == 0){
                dataController.Setbuyt();
            }else if(i == 1){
                dataController.Setbuyi();
            }else if(i == 2){
                dataController.Setbuyp();
            }else if(i == 3){
                dataController.Setbuyh();
            }
        }
    }
}
