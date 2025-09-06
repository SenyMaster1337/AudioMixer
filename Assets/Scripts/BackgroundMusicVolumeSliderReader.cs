using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusicVolumeSliderReader : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private VolumeChanger _volumeChanger;

    private const string Music = "MusicVolume";

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeMusicVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeMusicVolume);
    }

    public void ChangeMusicVolume(float volume)
    {
        _volumeChanger.ChangeVolume(Music, volume);
    }
}
