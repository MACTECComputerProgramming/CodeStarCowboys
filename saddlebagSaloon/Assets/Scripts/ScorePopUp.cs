using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePopUp : MonoBehaviour
{
    public float moveYSpeed;
    float increasesScaleAmount = .125f;
    float decreasesScaleAmount = 1f;
    private float timeBD = 1;
    private const float dTimerMax = 1f;
    

    private void Start()
    {
        timeBD = dTimerMax;
    }

    void Update()
    {


        if (timeBD > dTimerMax)
        {
            transform.localScale += Vector3.one * increasesScaleAmount * Time.deltaTime;
        }
        

        transform.position += new Vector3(0, moveYSpeed) * Time.deltaTime;

        timeBD -= Time.deltaTime;
        if(timeBD < 0)
        {
                Destroy(gameObject);   
        }
    }
}
