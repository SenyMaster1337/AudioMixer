using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderReader : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private VolumeChanger _volumeChanger;
    [SerializeField] private string _volumeName;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        _volumeChanger.ChangeVolume(_volumeName, volume);
    }
}
