using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadedEnemyView : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private RawImage _avatar;
    [SerializeField] private EnemySearcher _searcher;

    private void OnEnable()
    {
        _searcher.EnemyFound += OnEnemyFound;
    }

    private void OnDisable()
    {
        _searcher.EnemyFound -= OnEnemyFound;
    }

    private void OnEnemyFound(string name, Texture2D avatar)
    {
        _name.text = name;
        _avatar.texture = avatar;
    }
}
