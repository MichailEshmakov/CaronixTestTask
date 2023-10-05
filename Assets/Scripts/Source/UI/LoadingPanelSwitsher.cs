using UnityEngine;

public class LoadingPanelSwitsher : MonoBehaviour
{
    [SerializeField] private EnemySearcher _searcher;
    [SerializeField] private GameObject _gameObgect;

    private void OnEnable()
    {
        _searcher.SearchingStarted += OnSearchingStarted;
        _searcher.EnemyFound += OnEnemyFound;
    }

    private void OnDisable()
    {
        _searcher.SearchingStarted -= OnSearchingStarted;
        _searcher.EnemyFound -= OnEnemyFound;
    }

    private void OnSearchingStarted()
    {
        _gameObgect.SetActive(true);
    }

    private void OnEnemyFound(string name, Texture2D texture)
    {
        _gameObgect.SetActive(false);
    }
}
