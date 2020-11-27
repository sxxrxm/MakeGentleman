using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    private int mMoney = 0;
    private int mClickMoney = 0;
    private int sinsaTime = 2;

    void Awake() {
        mMoney = PlayerPrefs.GetInt("Money");
        mClickMoney = PlayerPrefs.GetInt("MoneyPerClick",5);
        sinsaTime = PlayerPrefs.GetInt("time ",2);
    }
    public void SetMoney(int newM){
        mMoney = newM;
        PlayerPrefs.SetInt("Money", mMoney);
    }
    public void AddMoney(int newM)
    {
        mMoney += newM;
        SetMoney(mMoney);

    }
    public void SubMoney(int newM)
    {
        mMoney -= newM;
        SetMoney(mMoney);
    }

    public int GetMoney()
    {
        return mMoney;
    }


    public void SetClickMoney(int newCM) {
        mClickMoney = newCM;
        PlayerPrefs.SetInt("MoneyPerClick", mClickMoney);
    }

    public int GetClickMoney()
    {
        return mClickMoney;
    }
    
    public int GetSinsaTime(){
        return sinsaTime;
    }
    
    public void SetSinsaTime(int newST){
        sinsaTime = newST;
        PlayerPrefs.SetInt("time ", sinsaTime);
    }
    public void SaveUpgradeButton(Upgrade upgradeButton){
        PlayerPrefs.SetInt("level ",upgradeButton.level);
        PlayerPrefs.SetInt("time ",upgradeButton.sinsaTime);
        PlayerPrefs.SetInt("cost ",upgradeButton.currentCost);
    }
    public void LoadUpgradeButton(Upgrade upgradeButton){
        upgradeButton.level = PlayerPrefs.GetInt("level ",1);
        upgradeButton.sinsaTime = PlayerPrefs.GetInt("time ",2);
        sinsaTime = PlayerPrefs.GetInt("time ",2);
        upgradeButton.currentCost = PlayerPrefs.GetInt("cost ",upgradeButton.startCurrentCost);
    }
    // public void LoadAlba(Backgroud itemAlba){
    //     itemAlba.level = PlayerPrefs.GetInt("AlbaLevel ",1);
    //     itemAlba.moneyForSec = PlayerPrefs.GetInt("moneyForSec ",2);
    //     itemAlba.isPurchase = PlayerPrefs.GetInt("PurchaseBool ",0);
    // }
    // public void SaveAlba(Backgroud itemAlba){
    //     PlayerPrefs.SetInt("AlbaLevel ",itemAlba.level);
    //     PlayerPrefs.SetInt("moneyForSec ",itemAlba.moneyForSec);
    //     PlayerPrefs.SetInt("PurchaseBool ",itemAlba.isPurchase);
    // }
}
