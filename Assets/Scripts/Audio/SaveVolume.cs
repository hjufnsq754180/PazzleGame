using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveVolume : MonoBehaviour
{
    private float _musicVolume;
    [SerializeField]
    private Slider _musicSlider;

    private void Awake()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1);
    }
}
