using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instanceSound;
    [SerializeField] private AudioSource sourceMusic, sourceSFX;

    private void Awake()
    {
        if (instanceSound == null)
        {
            instanceSound = this;
            return;
        } Destroy(this);
    }

    public void PlayMusic(AudioClip musicToPlay)
    {
        sourceMusic.clip = musicToPlay;
        sourceMusic.Play();
    }
    public void PlaySound(AudioClip soundToPlay)
    {
        sourceSFX.clip = soundToPlay;
        sourceSFX.Play();
    }
}
