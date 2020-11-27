<<<<<<< HEAD
﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
>>>>>>> f24903f... molla

public class Backgroud : MonoBehaviour
{

<<<<<<< HEAD
    // public Text moneyForSecDisplayer; 
    [HideInInspector]
    public int moneyForSec;
    public int startMoneyForSec = 2;
    public int Albalevel = 1;
=======
    public Text moneyForSecDisplayer; 
    [HideInInspector]
    public int moneyForSec;
    public int startMoneyForSec = 2;
    public int level = 1;
>>>>>>> f24903f... molla
    private int[] secMoneyArray = new int[5]{0,10,20,50,100};
    private int[] costArray = new int[5]{0,10000,35000,85000,170000};
    private int isPurchase = 0;


    public Data dataController;

    void Start(){
        dataController.LoadAlba(this);
        StartCoroutine("AddMoneyLoop");
        updateUI();
    }

    void OnClickAlba(){
<<<<<<< HEAD
        if(dataController.GetMoney()>=costArray[Albalevel]){
            isPurchase = 1;
            dataController.SubMoney(costArray[Albalevel]);
            Albalevel++;
=======
        if(dataController.GetMoney>=costArray[level]){
            isPurchase = 1;
            dataController.SubMoney(costArray[level]);
            level++;
>>>>>>> f24903f... molla
            updateUI();
            dataController.SaveAlba(this);
        }
    }

    IEnumerator AddMoneyLoop(){
        while(true){
            if(isPurchase == 1){
                dataController.AddMoney(moneyForSec);
        
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void updateUI() {

<<<<<<< HEAD
        //moneyForSecDisplayer.text = "초당 "+ secMoneyArray[Albalevel]+"코인";
=======
        moneyForSecDisplayer.text = "초당 "+ secMoneyArray[level]+"코인";
>>>>>>> f24903f... molla

    }
}
