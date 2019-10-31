using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBetweenScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static AudioBetweenScenes instance = null;
    public static AudioBetweenScenes Instance
    {
        get { return instance; }
    }

    // Update is called once per frame
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }
}
