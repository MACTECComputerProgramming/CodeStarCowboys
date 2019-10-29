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
        ScoreScript.highScore = findHighScore(ScoreScript.highScore);
        PlayerPrefs.SetFloat("HighScore", ScoreScript.highScore);
        PlayerPrefs.Save();

        highScoreText = GetComponent<Text>();
        string hsString = PlayerPrefs.GetFloat("HighScore").ToString();
        highScoreText.text = hsString;

    }

    public float findHighScore(float highscore)
    {
        if (ScoreScript.scoreValue > highscore)
        {
            highscore = ScoreScript.scoreValue;
        }

        return highscore;
    }

}
