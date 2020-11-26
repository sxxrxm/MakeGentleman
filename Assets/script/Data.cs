using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    private int mMoney = 0;
    private int mClickMoney = 0;
    private int sinsaTime = 0;

    void Awake() {
        mMoney = PlayerPrefs.GetInt("Money");
        mClickMoney = PlayerPrefs.GetInt("MoneyPerClick",5);
        sinsaTime = PlayerPrefs.GetInt("SinsaTime", 3);
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
        PlayerPrefs.GetInt("MoneyPerClick", mClickMoney);
    }

    public void AddClickMoney(int newCM)
    {
        mClickMoney += newCM;
        SetClickMoney(mClickMoney);
    }

    public int GetClickMoney()
    {
        return mClickMoney;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
