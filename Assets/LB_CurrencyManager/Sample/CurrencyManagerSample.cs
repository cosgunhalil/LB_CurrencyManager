using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManagerSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LB_CurrencyManager.Initialize();
        LB_CurrencyManager.IncreaseCurrencyCount(CurrencyType.gold, 100);
        LB_CurrencyManager.IncreaseCurrencyCount(CurrencyType.diamond, 250);

        LB_CurrencyManager.SaveCurrencyData();
    }
}
