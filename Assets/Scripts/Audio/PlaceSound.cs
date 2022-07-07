using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    public void PlayPlaceSound()
    {
        _audioSource.Play();
    }
}
