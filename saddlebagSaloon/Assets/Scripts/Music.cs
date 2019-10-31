using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool isPaused;
    public AudioClip MainMusic;
    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MainMusic;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {
            MusicSource.enabled = !MusicSource.enabled;
            MusicSource.Play();
      }
    }    
}
