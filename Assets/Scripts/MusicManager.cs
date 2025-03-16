using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource effectAudioSource;

    void Start()
    {
        // Joue la musique dès que le jeu commence
        musicAudioSource.Play();
    }

    public void PlaySoundEffect(AudioClip clip)
    {
        effectAudioSource.clip = clip;
        effectAudioSource.Play();
    }
}
