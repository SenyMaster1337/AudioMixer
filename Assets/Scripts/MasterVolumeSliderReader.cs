using UnityEngine;
using UnityEngine.UI;

public class MasterVolumeSliderReader : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private VolumeChanger _volumeChanger;

    private const string Master = "MasterVolume";

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeMasterVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeMasterVolume);
    }

    public void ChangeMasterVolume(float volume)
    {
        _volumeChanger.ChangeVolume(Master, volume);
    }
}
