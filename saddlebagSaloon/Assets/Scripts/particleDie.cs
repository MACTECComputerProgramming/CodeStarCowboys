using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDie : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 1f);
    }
}
