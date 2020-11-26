using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Upgrade : MonoBehaviour
{
    public Data dataController;
    public Text levelDisplayer;
    public Text upgradeDisplayer;
    public Text costDisplayer;
    public Text nowDisplayer; 

    public string upgradeName;
    [HideInInspector]
    public int startMoneyUpgrade = 3;  //처음 터치당 비용 증가량
    public int moneyUpgrade; //한번 업그레이드 했을시 증가량
    
    public float upgradePow = 1.07f; //신사 터치당 비용 비율

    [HideInInspector]
    public int level = 1;

    [HideInInspector]
    public int currentCost = 200; //현재 업그레이드 비용
    public int startCurrentCost = 200; //첫 업그레이드 비용

    public float costPow = 3.14f; //업그레이드 비용 비율

    void Start()
    {
        dataController.LoadUpgradeButton(this);
        updateUI();
    }

    public void upgradeLevel() { 
        if (dataController.GetMoney() >= currentCost) {
            dataController.SubMoney(currentCost); //돈 깎기
            level++; //레벨 올리기
            dataController.AddClickMoney(moneyUpgrade); //터치당 돈 업그레이드

            updateUpgrade(); 
            updateUI();

            dataController.SaveUpgradeButton(this);
        }
    }

    public void updateUpgrade() {
        moneyUpgrade = startMoneyUpgrade * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    public void updateUI() {
        levelDisplayer.text = "Lv."+ level;
        upgradeDisplayer.text = "터치당 "+moneyUpgrade+"코인\n신사타임 3초";
        costDisplayer.text = Convert.ToString(currentCost);
        nowDisplayer.text = "터치당 " + dataController.GetClickMoney()+"코인";

    }
}
