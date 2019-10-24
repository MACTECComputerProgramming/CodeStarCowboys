using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip MainMusic;
    public AudioSource MusicSource;
    void Start()
    {
        MusicSource.clip = MainMusic;


    }

    
    void Update()
    {
        MusicSource.Play();
        if (true)
        {

        }
    }
}
