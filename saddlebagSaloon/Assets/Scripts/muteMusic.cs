using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteMusic : MonoBehaviour
{

    public AudioSource audioSocurce;

    void Start()
    {
        audioSocurce = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSocurce.mute = !audioSocurce.mute;
        }
    }
}
