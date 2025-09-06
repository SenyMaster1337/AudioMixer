using UnityEngine;
using UnityEngine.UI;

public class MuteSoundButtonReader : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private SoundMuffler _soundMuffler;

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
        _soundMuffler.ToggleSound();
    }
}
