using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    // BGMの音源
    public AudioClip BGMAudioClip;
    public AudioClip GameClearBGM;
    public AudioClip GameOverBGM;

    // BGMを再生するSource
    public AudioSource BGMAudioSource;

    public void Start()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameOverBGM()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameClearBGM()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

}
