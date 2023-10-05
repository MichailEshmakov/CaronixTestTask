using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Wallet _wallet;

    private void Awake()
    {
        Fit();
    }

    private void OnEnable()
    {
        _wallet.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _wallet.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged()
    {
        Fit();
    }

    private void Fit()
    {
        _text.text = _wallet.GetMoney().ToString();
    }
}
