using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;
    [SerializeField] private Wallet _wallet;

    private int _value;

    public int Value => _value;

    private void Awake()
    {
        _value = Random.Range(_minValue, _maxValue + 1);
        _wallet.Add(_value);
    }
}
