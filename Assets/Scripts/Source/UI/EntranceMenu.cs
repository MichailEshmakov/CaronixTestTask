using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EntranceMenu : MonoBehaviour
{
    [SerializeField] private Button _continueButton; 
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private PlayerName _playerName;

    private void Awake()
    {
        if (string.IsNullOrEmpty(_playerName.Get()) == false)
        {
            LoadNextScene();
        }
    }

    private void OnEnable()
    {
        _continueButton.onClick.AddListener(OnContinueButtonClick);
    }

    private void OnDisable()
    {
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
    }

    private void OnContinueButtonClick()
    {
        if (string.IsNullOrEmpty(_input.text) == false)
        {
            _playerName.Set(_input.text);
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneIndexes.Search);
    }
}
