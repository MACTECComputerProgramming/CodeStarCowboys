using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System.Linq;


public class highScoreTable : MonoBehaviour
{
    //instantiate things
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<Transform> highScoreEntryTransformList;
    
   
    private void Awake()
    {
      

        entryContainer = transform.Find("highScoreEntryContainer");
        entryTemplate = entryContainer.Find("highScoreEntryTemplate");

        //set table to inactive
        entryTemplate.gameObject.SetActive(false);

        //create high score entry
        HighScoreEntry scoreEntry = new HighScoreEntry { score = scoreScript.score, name = "AAA" };


        //load saved high scores
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);


        //add new entry
        //highscores.highScoreEntryList.Add(scoreEntry);

        //save updated scores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();

        for (int i = 0; i < highscores.highScoreEntryList.Count; i++)
        {
            for (int j = 0; j < highscores.highScoreEntryList.Count; j++)
            {
                HighScoreEntry hs = highscores.highScoreEntryList[i];
                highscores.highScoreEntryList[i] = highscores.highScoreEntryList[j];
                highscores.highScoreEntryList[j] = hs;

            }

        }
       
        highScoreEntryTransformList = new List<Transform>();

        foreach(HighScoreEntry hse in highscores.highScoreEntryList)
        {
            //Display
            highScoreEntryForm(hse, entryContainer, highScoreEntryTransformList);
        }

     
        
    }

    //display entries
    private void highScoreEntryForm(HighScoreEntry highScoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 20f;


        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();

        entryRectTransform.anchoredPosition = new Vector2(97, -(templateHeight * transformList.Count));

        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;

        string rankString;

        //determine rank string

        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        //set rank 
        entryTransform.Find("playerRank").GetComponent<Text>().text = rankString;

        string name = highScoreEntry.name;
        //set name
        entryTransform.Find("playerInitial").GetComponent<Text>().text = name;

        //set score
        entryTransform.Find("playerScore").GetComponent<Text>().text = highScoreEntry.score.ToString();

        transformList.Add(entryTransform);

    }
    
    private class Highscores
    {
        public List<HighScoreEntry> highScoreEntryList;

    }



    /*
         * Represents a single high score entry
         */

    [System.Serializable]
    private class HighScoreEntry
    {
        public float score;
        public string name; 

    }

    
}
