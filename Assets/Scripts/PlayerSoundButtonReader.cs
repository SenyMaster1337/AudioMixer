using UnityEngine;
using UnityEngine.UI;

public class PlayerSoundButtonReader : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private SoundPlayer _soundPlayer;

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
        _soundPlayer.PlaySound();
    }
}
