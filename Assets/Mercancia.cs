using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancia : MonoBehaviour
{
   
   public Mercancia mercancia;
    public float cost;
    public Money_Manager MoneyManager;

    void Start()
    {
        // Buscar el Money_Manager si no está asignado en el Inspector
        if (MoneyManager == null)
        {
            MoneyManager = FindObjectOfType<Money_Manager>();
        }
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (mercancia)
            {
                MoneyManager = FindObjectOfType<Money_Manager>();
            }
    }


}