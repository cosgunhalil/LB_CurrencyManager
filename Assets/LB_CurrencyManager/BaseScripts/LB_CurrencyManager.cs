using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LB_CurrencyManager
{
    private static LB_CurrencyData currencyData;

    public static void Initialize() 
    {
        Debug.Log("Currency Manager started.");
        LoadCurrencyData();
    }

    private static void LoadCurrencyData()
    {
        LB_LocalDataLoader dataLoader = new LB_LocalDataLoader();
        currencyData = dataLoader.LoadData<LB_CurrencyData>("CurrencyData");

        if (currencyData == null)
        {
            currencyData = new LB_CurrencyData()
            {
                Currencies = new List<Currency>
                {
                    { new Currency{Type = CurrencyType.gold } },
                    { new Currency{Type = CurrencyType.diamond } }
                }
            };
        }
    }

    public static void SaveCurrencyData() 
    {
        LB_LocalDataSaver dataSaver = new LB_LocalDataSaver();
        dataSaver.SaveData<LB_CurrencyData>(currencyData, "CurrencyData");
    }

    public static void IncreaseCurrencyCount(CurrencyType currencyType, int count) 
    {
        currencyData.AddCount(currencyType, count);
    }

    public static void DecreaseCurrencyCount(CurrencyType currencyType, int count)
    {
        currencyData.DecreaseCount(currencyType, count);
    }
}
