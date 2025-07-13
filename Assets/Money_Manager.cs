using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Manager : MonoBehaviour
{
    public float money;
    public UImanager uimanager;

    void Start()
    {
        // Si no se asignó en el Inspector, se busca automáticamente
        if (uimanager == null)
        {
            uimanager = FindObjectOfType<UImanager>();
        }

        uimanager.UpdateMoneyTxt(money.ToString("F2"));
    }

    public void UpdateMoney(float moneyToAdd)
    {
        // Evitar saldo negativo
        if (money + moneyToAdd < 0)
        {
            return;
        }

        money += moneyToAdd;

        // Actualizar la UI
        if (uimanager != null)
        {
            uimanager.UpdateMoneyTxt(money.ToString("F2"));
        }
    }
}
