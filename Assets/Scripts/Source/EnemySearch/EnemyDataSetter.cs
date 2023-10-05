using UnityEngine;

public class EnemyDataSetter : MonoBehaviour
{
    [SerializeField] private EnemySearcher _searcher;
    [SerializeField] private EnemyData _data;

    private void Awake()
    {
        _data.ResetName();
    }

    private void OnEnable()
    {
        _searcher.EnemyFound += OnEnemyFound;
    }

    private void OnDisable()
    {
        _searcher.EnemyFound -= OnEnemyFound;
    }

    private void OnEnemyFound(string name, Texture2D texture)
    {
        _data.SetName(name);
    }
}
