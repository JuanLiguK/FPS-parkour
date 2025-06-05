using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Manager : MonoBehaviour
{
    public float money;
    public UImanager uimanager;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
            money += moneyToAdd;
        return;
    }
    money += moneyToAdd; 
}
