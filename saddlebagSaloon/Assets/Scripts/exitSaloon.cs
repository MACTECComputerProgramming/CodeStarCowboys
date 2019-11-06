using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitSaloon : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void doQuit()
    {
        Application.Quit();
        Debug.Log("quit");
    }


}
