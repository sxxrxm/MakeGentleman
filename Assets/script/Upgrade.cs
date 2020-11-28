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

    [HideInInspector]
    private int[] upgradeArray = new int[20]{0,5,8,12,17,23,32,45,60,77,95,114,135,160,187,212,241,270,301,332};

    [HideInInspector]
    public int level = 1;
    public int sinsaTime = 2;

    [HideInInspector]
    public int currentCost = 200; //현재 업그레이드 비용
    public int startCurrentCost = 200; //첫 업그레이드 비용

    public float costPow = 2.84f; //업그레이드 비용 비율

    void Start()
    {
        dataController.LoadUpgradeButton(this);
        updateUI();
    }

    public void upgradeLevel() { 
        if (dataController.GetMoney() >= currentCost) {
            dataController.SubMoney(currentCost); //돈 깎기
            level++; //레벨 올리기
            sinsaTime++;
            dataController.SetClickMoney(upgradeArray[level]); //터치당 돈 업그레이드
            updateUpgrade(); 
            updateUI();

            dataController.SaveUpgradeButton(this);
        }
    }

    public void updateUpgrade() {
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    public void updateUI() {
        levelDisplayer.text = "Lv."+ level;
        upgradeDisplayer.text = "터치당 "+upgradeArray[level+1]+"코인\n신사타임 " + sinsaTime +"초";
        costDisplayer.text = Convert.ToString(currentCost);
        nowDisplayer.text = "터치당 " + upgradeArray[level]+"코인";

    }
}
