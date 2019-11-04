using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        

        if(ScoreScript.scoreValue > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", ScoreScript.scoreValue);
            PlayerPrefs.Save();
        }

        PlayerPrefs.Save();

        ScoreScript.highScore = PlayerPrefs.GetFloat("HighScore");

        //PlayerPrefs.SetFloat("HighScore", ScoreScript.highScore);
        // PlayerPrefs.Save();

        highScoreText = GetComponent<Text>();
        string hsString = ScoreScript.highScore.ToString();
        highScoreText.text = hsString;

    }

   
}
