using UnityEngine;
using UnityEngine.Audio;

public class SoundPanel : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private bool _isSoundEnabled;

    public void ToggleSound()
    {
        if (_isSoundEnabled)
        {
            _audioMixer.SetFloat("MasterVolume", 0);
            _isSoundEnabled = false;
        }
        else
        {
            _audioMixer.SetFloat("MasterVolume", -80);
            _isSoundEnabled = true;
        }
    }

    public void ChangeVolumeMasterSound(float volume)
    {
        _audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeVolumeMusicSound(float volume)
    {
        _audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeVolumeEffectSound(float volume)
    {
        _audioMixer.SetFloat("EffectVolume", Mathf.Log10(volume) * 20);
    }
}
