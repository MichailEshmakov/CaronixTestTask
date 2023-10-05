using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnemySearcher : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private EnemySearcher _searcher;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        _searcher.Search();
    }
}
