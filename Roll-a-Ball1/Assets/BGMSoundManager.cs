using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    // BGMÇÃâπåπ
    public AudioClip BGMAudioClip;
    public AudioClip GameClearBGM;
    public AudioClip GameOverBGM;

    // BGMÇçƒê∂Ç∑ÇÈSource
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
