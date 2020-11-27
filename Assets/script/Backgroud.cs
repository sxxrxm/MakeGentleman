using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Backgroud : MonoBehaviour
{
    public Image blind;
    public Text moneyForSecDisplayer; 

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
        
        if(dataController.getbuyt() == 1){
            Destroy(blind);
        }
        if(dataController.getbuyi() == 1){
            Destroy(blind);
        }
        if(dataController.getbuyp() == 1){
            Destroy(blind);
        }
        if(dataController.getbuyh() == 1){
            Destroy(blind);
        }

        StartCoroutine(AddMoneyLoop());
        updateUI();
    }

    public void OnClickAlba1()
    {
        if (dataController.GetMoney() >= costArray[1])
        {
            dataController.SubMoney(costArray[1]);
            alba1 = 1;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    public void OnClickAlba2()
    {
        if (dataController.GetMoney() >= costArray[2])
        {
            dataController.SubMoney(costArray[2]);
            alba2 = 1;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    public void OnClickAlba3()
    {
        if (dataController.GetMoney() >= costArray[3])
        {
            dataController.SubMoney(costArray[3]);
            alba3 = 1;
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    public void OnClickAlba4()
    {
        if (dataController.GetMoney() >= costArray[4])
        {
            dataController.SubMoney(costArray[4]);
            alba4 = 1;
            updateUI();
            dataController.SaveAlba(this);
        }
    }

    IEnumerator AddMoneyLoop()
    {
        while (true)
        {
            if (alba1 == 1){
                dataController.AddMoney(secMoneyArray[1]);
            }
            if (alba2 == 1){
                dataController.AddMoney(secMoneyArray[2]);
            }
            if (alba3 == 1){
                dataController.AddMoney(secMoneyArray[3]);
            }
            if (alba4 == 1){
                dataController.AddMoney(secMoneyArray[4]);
            }

            yield return new WaitForSeconds(1.0f);
        }
    }

    public void updateUI()
    {
        int sum = 0;
        if(dataController.getbuyt() == 1 && alba1 == 1){
            sum += 10;
        }
        if(dataController.getbuyi() == 1 && alba2 == 1){
             sum += 20;
        }
        if(dataController.getbuyp() == 1 && alba3 == 1){
            sum += 50;

        }
        if(dataController.getbuyh() == 1 && alba4 == 1){
            sum += 100;
        }
        moneyForSecDisplayer.text = "초당 "+ sum+"코인";

    }
}
