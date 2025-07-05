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
    // Update is called once per frame

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
}
