using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangeImage : MonoBehaviour
{
    public Text ttext;
    public Text itext;
    public Text ptext;
    public Text htext;

    public Image TestIm0; //기존에 존제하는 이미지
    public Sprite Im1; //바뀌어질 이미지
    public Image coin;
    public Data dataController;
    public int i;
    public int[] prices = {5000, 16000, 40000, 100000};
    public int buy = 0;
    public Text fix;
    public int buyt = 0;
    public int buyi = 0;
    public int buyp = 0;
    public int buyh = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        buyt = dataController.getbuyt();
        buyi = dataController.getbuyi();
        buyp = dataController.getbuyp();
        buyh = dataController.getbuyh();
        
        if(dataController.GetMoney()>=prices[i]){
            TestIm0.sprite = Im1;
            if(buyt==1){
                ttext.text = "보유 중";
            }else if(buyi==1){
                itext.text = "보유 중";
            }else if(buyp==1){
                ptext.text = "보유 중";
            }else if(buyh==1){
                htext.text = "보유 중";
            } 
        }
    }
    public void buyStore(){
        if(dataController.GetMoney()>=prices[i]){
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
