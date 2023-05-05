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
    public TextMeshPro  ThisTextScore;
    public TextMeshPro  ThisTextCountdown;
    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
        SetTimer();
    }
    void FixedUpdate()
    {

        
        IsTimerZero();
    }

    public void scoresystem(int Scoring)
    {
        Score += Scoring;
        SetTimer();
        ThisTextScore.text = Score.ToString();
        Debug.Log(Score);
    }
    
    public void IsTimerZero()
    {
        timercounter -= Time.deltaTime;
        ThisTextCountdown.text = timercounter.ToString("0.0");
        if(timercounter <= 0f)
        {

            Score = 0;
            ThisTextScore.text = Score.ToString();
            ThisTextCountdown.text = timercounter.ToString("0");
            timercounter = 0;
            
        }
    }

    void SetTimer()
    {
        timercounter = 50f / Score;
    }
}
