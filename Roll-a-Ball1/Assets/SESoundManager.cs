using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESoundManager : MonoBehaviour
{
    // SEの音源
    public AudioClip SEAudioClip;

    // SEを再生するSource
    public AudioSource SEAudioSource;

    public void PlayPickUpItemSE()
    {
        SEAudioSource.clip = SEAudioClip;
        SEAudioSource.Play();
    }
}
