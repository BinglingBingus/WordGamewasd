using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreinfo : MonoBehaviour
{

    public GameObject   DetectLetter;
    public int          Score;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       
    }

    public void scoresystem(int Score)
    {
        Score += 50;
        Debug.Log(Score);
    }
}
