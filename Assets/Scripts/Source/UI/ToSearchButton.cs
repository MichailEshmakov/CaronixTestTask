
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToSearchButton : MonoBehaviour
{
    [SerializeField] private Button _button;

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
        SceneManager.LoadScene(SceneIndexes.Search);
    }
}
