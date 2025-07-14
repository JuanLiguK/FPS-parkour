using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Manager : MonoBehaviour
{
    public Mercancia mercancia;
    public float money;
    public UImanager uimanager;

    void Start()
    {

        if (uimanager == null)
        {
            uimanager = FindObjectOfType<UImanager>();
        }

        uimanager.UpdateMoneyTxt(money.ToString("F2"));
    }

    public void UpdateMoney(float moneyToAdd)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           

                if (money + moneyToAdd < 0)
                {
                    return;
                }

                money += moneyToAdd;


                if (uimanager != null)
                {
                    uimanager.UpdateMoneyTxt(money.ToString("F2"));
                }
            
        }
    }
}