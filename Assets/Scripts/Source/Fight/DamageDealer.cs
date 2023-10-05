using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private int _minDamage;
    [SerializeField] private int _maxDamage;
    [SerializeField] private Damagable _damagable;

    public void Hit()
    {
        Damage damage = new Damage(Random.Range(_minDamage, _maxDamage + 1));
        _damagable.TakeDamage(damage);
    }
}
