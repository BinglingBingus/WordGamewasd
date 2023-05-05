using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreinfo : MonoBehaviour
{

    public GameObject   DetectLetter;
    public int          Score;
    public int          Scoring;
    public float        timercounter;
    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
    }

    public void scoresystem(int Scoring)
    {
        Score += Scoring;
        GetComponent<TMP_Text>().text = Score.ToString();
        Debug.Log(Score);
    }
    
    public void scoretimer()
    {
        //make timer smaller as score gets higher
        // number1 = score /100 (0.1)
        // number 2 = (score /10) - number1  // so 1 - 0.1 (0.9), 2 - 0.2 (1.8) need to minus from a flat
        timercounter = Score / 10;
    }
}
