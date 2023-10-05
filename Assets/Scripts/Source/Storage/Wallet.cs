using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private const string MoneyKey = "Money";

    public event Action MoneyChanged;

    public void Add(int delta)
    {
        // TODO: don't allow to reduce with this method
        PlayerPrefs.SetInt(MoneyKey, GetMoney() + delta);
        MoneyChanged?.Invoke();
    }

    public int GetMoney()
    {
        return PlayerPrefs.GetInt(MoneyKey);
    }
}
