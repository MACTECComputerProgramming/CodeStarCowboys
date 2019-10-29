using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour
{
    [SerializeField]
    public Text highScoreText;
    private void Start()
    {
        highScoreText.text = "16";
    }
}
