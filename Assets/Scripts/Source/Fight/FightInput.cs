using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightInput : MonoBehaviour
{
    [SerializeField] private DamageDealer _damageDealer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _damageDealer.Hit();
        }
    }
}
