using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class LB_CurrencyData
{
    public List<Currency> Currencies;

    public LB_CurrencyData() 
    {
        Currencies = new List<Currency>((int)CurrencyType.count);
    }

    public void AddCount(CurrencyType currencyType, int count)
    {
        Currencies[(int)currencyType].Count += count;
    }

    public void DecreaseCount(CurrencyType currencyType, int count)
    {
        Currencies[(int)currencyType].Count -= count;
    }
}

[Serializable]
public class Currency 
{
    public CurrencyType Type;
    public int Count;
}
