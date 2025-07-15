using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public Money_Manager moneymanager;
    public GameObject InteractionMessage;
    public Mercancia mercancia;
    // Start is called before the first frame update
    void Start()
    {
        InteractionMessage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (mercancia)
            {
                moneymanager.UpdateMoney(mercancia.cost);
                Destroy(mercancia.gameObject);
                StopInteraction();
            }



    }


    private void OnTriggerEnter(Collider other)
    {

        mercancia = other.GetComponent<Mercancia>();
        if (mercancia)
        {
            InteractionMessage.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        InteractionMessage.SetActive(false);
        mercancia = null;
    }
}
