using TMPro;
using UnityEngine;

public class RewardView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Reward _reward;

    private void Start()
    {
        _text.text = _reward.Value.ToString();
    }
}
