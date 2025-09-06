using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private int _valueChange = 20;

    public void ChangeMasterVolume(float volume)
    {
        ChangeVolume("MasterVolume", volume);
    }

    public void ChangeMusicVolume(float volume)
    {
        ChangeVolume("MusicVolume", volume);
    }

    public void ChangeEffectVolume(float volume)
    {
        ChangeVolume("EffectVolume", volume);
    }

    private void ChangeVolume(string nameSound, float volume)
    {
        _audioMixer.SetFloat(nameSound, Mathf.Log10(volume) * _valueChange);
    }
}
