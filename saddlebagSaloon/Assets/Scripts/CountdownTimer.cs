using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 5f;
    public GameObject target;
    public GameObject gameTimer;


    [SerializeField]
    Text countDownText;
    

    void Start()
    {
        currentTime = startingTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        

        if (currentTime <= 0)
        {
            countDownText.enabled = false;
            target.SetActive(true);
            gameTimer.SetActive(true);
        }
    }
}
