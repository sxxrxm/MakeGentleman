using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    private int mMoney = 0;
    private int mClickMoney = 0;
    private int sinsaTime = 2;
    public PlayerPrefsX PlayerPrefsX;
    private int buyt = 0;
    private int buyi = 0;
    private int buyp = 0;
    private int buyh = 0;

    void Awake(){
        mMoney = PlayerPrefs.GetInt("Money");
        mClickMoney = PlayerPrefs.GetInt("MoneyPerClick",5);
        sinsaTime = PlayerPrefs.GetInt("time ",2);
        buyt = PlayerPrefs.GetInt("buyt",0);
        buyi = PlayerPrefs.GetInt("buyi",0);
        buyp = PlayerPrefs.GetInt("buyp",0);
        buyh = PlayerPrefs.GetInt("buyh",0);

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

    public void Setbuyt(){
        buyt = 1;
        PlayerPrefs.SetInt("buyt", buyt);
    }

     public void Setbuyi(){
        buyi = 1;
        PlayerPrefs.SetInt("buyi", buyi);
    }
     public void Setbuyp(){
        buyp = 1;
        PlayerPrefs.SetInt("buyp", buyp);
    }
     public void Setbuyh(){
        buyh = 1;
        PlayerPrefs.SetInt("buyh", buyh);
    }
    public int getbuyt(){
        return getbuyt;
    }

     public int getbuyi(){
        return getbuyi;
    }
     public int getbuyp(){
        return getbuyp;
    }
     public int getbuyh(){
        return getbuyh;
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
    public void LoadAlba(Backgroud itemAlba){
        itemAlba.Albalevel = PlayerPrefs.GetInt("AlbaLevel ",1);
        itemAlba.moneyForSec = PlayerPrefs.GetInt("moneyForSec ",2);
        itemAlba.alba1 = PlayerPrefs.GetInt("alba1 ",0);
        itemAlba.alba2 = PlayerPrefs.GetInt("alba2 ",0);
        itemAlba.alba3 = PlayerPrefs.GetInt("alba3 ",0);
        itemAlba.alba4 = PlayerPrefs.GetInt("alba4 ",0);
    }
    public void SaveAlba(Backgroud itemAlba){
        PlayerPrefs.SetInt("AlbaLevel ",itemAlba.Albalevel);
        PlayerPrefs.SetInt("moneyForSec ",itemAlba.moneyForSec);
        PlayerPrefs.SetInt("alba1 ",itemAlba.alba1);
        PlayerPrefs.SetInt("alba2 ",itemAlba.alba2);
        PlayerPrefs.SetInt("alba3 ",itemAlba.alba3);
        PlayerPrefs.SetInt("alba4 ",itemAlba.alba4);

    }
    public void LoadStore()
}
