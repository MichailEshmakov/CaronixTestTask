using TMPro;
using UnityEngine;

public class PlayerNameView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private PlayerName _playerName;

    private void Awake()
    {
        _text.text = _playerName.Get();
    }
}
