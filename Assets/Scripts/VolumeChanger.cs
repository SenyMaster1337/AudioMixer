using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private float _valueChange = 20f;
    private float _minVolume = 0.0001f;

    public void ChangeVolume(string nameGroup, float volume)
    {
        float volumeDB = ConvertLinearToDecibels(volume);
        _audioMixer.SetFloat(nameGroup, volumeDB);
    }

    private float ConvertLinearToDecibels(float linearVolume)
    {
        return Mathf.Log10(Mathf.Max(linearVolume, _minVolume)) * _valueChange;
    }
}
