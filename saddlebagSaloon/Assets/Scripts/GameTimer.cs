using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{

    public static float currentTime = 0f;
    private float startingTime = 60f;
    

    [SerializeField]
    Text gameCountDown;

    

    void Start()
    {
        currentTime = startingTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        gameCountDown.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            gameCountDown.enabled = false;
            SceneManager.LoadScene(4);
        }


    }
}
