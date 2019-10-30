using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip MainMusic;
    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MainMusic;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) ;
        {
            //MusicSource = !MusicSource;
            MusicSource.Play();
        }
    }
}
