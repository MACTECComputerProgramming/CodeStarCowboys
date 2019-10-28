using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    
    public AudioSource MusicSource;
    public AudioClip MainMusic;
    void Start()
    {
        MusicSource.clip = MainMusic;


    }

    
    void FixedUpdate()
    {
        
        

        if (Input.GetKeyDown(KeyCode.M))
        {
            

            MusicSource.enabled = !MusicSource.enabled;
            
        }
        
    }
}
