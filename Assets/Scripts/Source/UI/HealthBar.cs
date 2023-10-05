using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    private void Start()
    {
        Fit();
    }

    private void Fit()
    {
        Debug.Log(_health.Value);
        Debug.Log(_health.StartValue);
        float value = _health.Value / (float)_health.StartValue;
        Debug.Log(value);
        _slider.value = value;
    }

    private void OnHealthChanged()
    {
        Fit();
    }
}
