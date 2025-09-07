using UnityEngine;
using UnityEngine.Audio;

public class SoundMuffler : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private const string MasterVolume = "MasterVolume";

    private bool _isSoundEnabled;
    private float _minValue = -80;
    private float _maxValue = 0;

    public void ToggleSound()
    {
        if (_isSoundEnabled)
        {
            _audioMixer.SetFloat(MasterVolume, _maxValue);
            _isSoundEnabled = false;
        }
        else
        {
            _audioMixer.SetFloat(MasterVolume, _minValue);
            _isSoundEnabled = true;
        }
    }
}
