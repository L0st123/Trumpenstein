using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.iOS;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource[] audioSources;
    public static AudioManagerScript instance;
    public float sfxvol = 0;
    public float musicvol = 0;

    public AudioClip[] clips;

    private void Start()
    {

        audioSources[0].Play();

    }



    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSources[1].Play();
    }


    public void PlaySFX( int clipToPlay )
    {
        //play clip on audiosource 0
        audioSources[0].clip = clips[clipToPlay];
        audioSources[0].Play();
        print("play clip");
    }


}