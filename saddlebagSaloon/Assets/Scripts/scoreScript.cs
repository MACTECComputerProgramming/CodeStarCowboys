using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public static float score = 16f;
    
    
    [SerializeField]
    public Text scoreText;

    private void Start()
    {
        scoreText.text = score.ToString();

      
        
    }

    public static void addUp(float additive)
    {
        score = score + additive;
    }

}
