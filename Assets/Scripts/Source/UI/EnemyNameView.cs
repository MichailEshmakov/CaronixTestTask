using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyNameView : MonoBehaviour
{
    [SerializeField] private EnemyData _data;
    [SerializeField] private TMP_Text _text;

    private void Awake()
    {
        _text.text = _data.GetName();
    }
}
