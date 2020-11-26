using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UI : MonoBehaviour
{
    public Text moneyDisplayer;
    public Text moneyClickDisplayer;
    public Data dataController;

    void Update() {
        moneyDisplayer.text = Convert.ToString(dataController.GetMoney());
        moneyClickDisplayer.text = "터치당 "+ dataController.GetClickMoney()+ "코인";
    }
}
