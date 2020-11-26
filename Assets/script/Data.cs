using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    private int mMoney = 0;
    private int mClickMoney = 0;
    private float sinsaTime = 2;

    void Awake() {
        mMoney = PlayerPrefs.GetInt("Money");
        mClickMoney = PlayerPrefs.GetInt("MoneyPerClick",5);
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
    public void SaveUpgradeButton(Upgrade upgradeButton){
        PlayerPrefs.SetInt("level ",upgradeButton.level);
        PlayerPrefs.SetInt("time ",upgradeButton.sinsaTime);
        PlayerPrefs.SetInt("cost ",upgradeButton.currentCost);
    }
    public void LoadUpgradeButton(Upgrade upgradeButton){
        upgradeButton.level = PlayerPrefs.GetInt("level ",1);
        upgradeButton.sinsaTime = PlayerPrefs.GetInt("time ",1);
        upgradeButton.currentCost = PlayerPrefs.GetInt("cost ",upgradeButton.startCurrentCost);
    }

}
