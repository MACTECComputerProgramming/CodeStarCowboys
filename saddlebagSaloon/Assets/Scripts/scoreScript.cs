using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreScript : MonoBehaviour
{
    public static float score = 0f;
   
    public static void addUp(float additive)
    {
        score = score + additive;
    }

  
}
