// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Upgrade : MonoBehaviour
// {
//     [HideInInspector]
//     public int startMoneyUpgrade;  //처음 터치당 비용
//     public int moneyUpgrade; //신사 업그레이드시 터치당
//     public float upgradePow = 1.07f; //신사 터치당 비용 비율

//     [HideInInspector]
//     public int level = 1;

//     [HideInInspector]
//     public int currentCost = 200; //업그레이드 비용
//     public int startCurrentCost = 200; //첫 업그레이드 비용

//     public float costPow = 3.14f; //업그레이드 비용 비율
//     // Start is called before the first frame update
//     void Start()
//     {
//         currentCost = startCurrentCost;
//         level = 1;
//         moneyUpgrade = startMoneyUpgrade;
//     }

//     public void upgradeLevel() { 
//         if (DataController.GetInstance().GetMoney() >= currentCost) {
//             DataController.GetInstance().SubMoney(currentCost);
//             level++;
//             DataController.GetInstance().AddClickMoney(moneyUpgrade);
//         }
//     }

//     public void updateUpgrade() {
//         moneyUpgrade = startMoneyUpgrade * (int)Mathf.Pow(upgradePow, level);
//         currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
//     }
// }
