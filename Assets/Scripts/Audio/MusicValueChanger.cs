using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicValueChanger : MonoBehaviour
{
    [SerializeField]
    private AudioMixerGroup _mixer;

    [SerializeField]
    private Slider _musicSlider;
    [SerializeField]
    private Slider _soundSlider;

    private void Start()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1);
        _soundSlider.value = PlayerPrefs.GetFloat("SoundVolume", 1);
    }

    public void ChangeMusicVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 50);
        PlayerPrefs.SetFloat("MusicVolume", _musicSlider.value);
    }
    
    public void ChangeSoundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("SoundVolume", Mathf.Log10(volume) * 50);
        PlayerPrefs.SetFloat("SoundVolume", _soundSlider.value);
    }

    public void SetAudioVolume()
    {
        _mixer.audioMixer.SetFloat("MusicVolume", _musicSlider.value);
        _mixer.audioMixer.SetFloat("SoundVolume", _soundSlider.value);
    }
}
