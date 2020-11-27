using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroud : MonoBehaviour
{
    

    // public Text moneyForSecDisplayer; 
    [HideInInspector]
    public int moneyForSec;
    public int startMoneyForSec = 2;
    public int alba1 = 0;
    public int alba2 = 0;
    public int alba3 = 0;
    public int alba4 = 0;
    private int[] secMoneyArray = new int[5] { 0, 10, 20, 50, 100 };
    private int[] costArray = new int[5] { 0, 10000, 35000, 85000, 170000 };


    public Data dataController;

    void Start()
    {
        dataController.LoadAlba(this);
        StartCoroutine("AddMoneyLoop");
        updateUI();
    }

    void OnClickAlba1()
    {
        if (dataController.GetMoney() >= costArray[Albalevel])
        {
            dataController.SubMoney(costArray[Albalevel]);
            Albalevel++;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba2()
    {
        if (dataController.GetMoney() >= costArray[Albalevel])
        {
            dataController.SubMoney(costArray[Albalevel]);
            Albalevel++;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba3()
    {
        if (dataController.GetMoney() >= costArray[Albalevel])
        {
            dataController.SubMoney(costArray[Albalevel]);
            Albalevel++;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba4()
    {
        if (dataController.GetMoney() >= costArray[Albalevel])
        {
            dataController.SubMoney(costArray[Albalevel]);
            Albalevel++;
            updateUI();
            dataController.SaveAlba(this);
        }
    }

    IEnumerator AddMoneyLoop()
    {
        while (true)
        {
            if ( == 1)
            {
                dataController.AddMoney(moneyForSec);

            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void updateUI()
    {

        //moneyForSecDisplayer.text = "초당 "+ secMoneyArray[Albalevel]+"코인";

    }
}
