using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Health : MonoBehaviour
{
    [SerializeField] private int _minStartValue;
    [SerializeField] private int _maxStartValue;

    private int _startValue;
    private int _value;

    public int StartValue => _startValue;
    public int Value => _value;

    public event Action Changed; 
    public event Action BecomeZero; 

    private void Awake()
    {
        _startValue = Random.Range(_minStartValue, _maxStartValue + 1);
        _value = _startValue;
    }

    public void ChangeBy(int delta)
    {
        // TODO: limit with max;

        if (_value + delta <= 0)
        {
            _value = 0;
            Changed?.Invoke();
            BecomeZero?.Invoke();
        }
        else
        {
            _value += delta;
            Changed?.Invoke();
        }
    }
}
