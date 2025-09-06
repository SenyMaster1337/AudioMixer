using UnityEngine;
using UnityEngine.UI;

public class EffectVolumeSliderReader : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private VolumeChanger _volumeChanger;

    private const string Effect = "EffectVolume";

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeEffectVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeEffectVolume);
    }

    public void ChangeEffectVolume(float volume)
    {
        _volumeChanger.ChangeVolume(Effect, volume);
    }
}
