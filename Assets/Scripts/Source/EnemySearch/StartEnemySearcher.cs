using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnemySearcher : MonoBehaviour
{
    [SerializeField] private EnemySearcher _searcher;

    private void Start()
    {
        _searcher.Search();
    }
}
