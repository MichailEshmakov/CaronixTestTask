using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage
{
    private int _value;

    public int Value => _value;

    public Damage(int value)
    {
        _value = value;
    }
}
