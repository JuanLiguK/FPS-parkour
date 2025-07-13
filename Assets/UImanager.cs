using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    public void UpdateMoneyTxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }

    void Start()
    {
        // Puedes inicializar el texto si quieres
        UpdateMoneyTxt("0");
    }
}