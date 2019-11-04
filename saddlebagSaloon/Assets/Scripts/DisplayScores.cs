using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour
{
    // Start is called before the first frame update

    public Text finalScore;
    
    void Start()
    {
       
        finalScore = GetComponent<Text>();

        string scoreString = ScoreScript.scoreValue.ToString();
        finalScore.text = scoreString;

    }

  

   
}
