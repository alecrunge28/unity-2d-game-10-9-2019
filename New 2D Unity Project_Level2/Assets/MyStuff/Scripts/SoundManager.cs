using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip coinCollectSound;

    public AudioClip HitboxSound;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }   
    }

    public void PlaycoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }
    public void PlayHitboxSound()
    {
        audioSource.clip = HitboxSound;
        audioSource.Play();
    }
}
