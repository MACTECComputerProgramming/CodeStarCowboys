using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearScore : MonoBehaviour
{
    // Start is called before the first frame update
    public void clear()
    {
        ScoreScript.scoreValue = 0;
    }
}
