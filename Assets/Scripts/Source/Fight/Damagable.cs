using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] private Health _health;

    public void TakeDamage(Damage damage)
    {
        _health.ChangeBy(-damage.Value);
    }
}
