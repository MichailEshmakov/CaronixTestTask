using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryLoader : MonoBehaviour
{
    [SerializeField] private Health _enemyHealth;

    private void OnEnable()
    {
        _enemyHealth.BecomeZero += OnEnemyHealthBecomeZero;
    }

    private void OnDisable()
    {
        _enemyHealth.BecomeZero -= OnEnemyHealthBecomeZero;
    }

    private void OnEnemyHealthBecomeZero()
    {
        SceneManager.LoadScene(SceneIndexes.Result);
    }
}
