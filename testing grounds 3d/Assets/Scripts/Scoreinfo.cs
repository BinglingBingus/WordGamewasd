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
        if(Score >= 0 && Score <= 200)
        {
            ThisTextScore.color = Color.green;
        }
        if(Score > 200 && Score <= 400)
        {
            ThisTextScore.color = Color.yellow;
        }
        if(Score > 400 && Score <= 800)
        {
            ThisTextScore.color = new Color( 1f, 0.3f,0.1f);
        }
        if(Score > 800 && Score <= 1200)
        {
            ThisTextScore.color = Color.red;
        }
        if(Score > 1200)
        {
            ThisTextScore.color = Color.magenta;
        }
    }
    
    public void IsTimerZero()
    {
        timercounter -= Time.deltaTime;
        ThisTextCountdown.text = timercounter.ToString("0.0");
        if(timercounter <= 0f)
        {

                //infinitely pops off
            Score = 0;
            ThisTextScore.text = Score.ToString();
            ThisTextCountdown.text = timercounter.ToString("0");
            timercounter = 5f;
            
        }
    }

    void SetTimer()
    {
        if(Score < 0)
        {
            timercounter = 10f;
        }
        if(Score >= 0 && Score <= 100)
        {
        timercounter = 5f;
        }

        if(Score >= 100 && Score <= 200)
        {
        timercounter = 4f;
        }
        if(Score >= 200 && Score <= 300)
        {
        timercounter = 3f;
        }
        if(Score >= 300 && Score <= 400)
        {
        timercounter = 2f;
        }
        if(Score >= 400 && Score <= 800)
        {
        timercounter = 1f;
        }
        if(Score >= 800 && Score <= 1200)
        {
        timercounter = 0.8f;
        }
        if(Score > 1200)
        {
        timercounter = 0.5f;
        }
        //if(Score >= 600 &&  Score <= 700)

        //if(Score >= 700)
        //{
        //timercounter = 0.3f;
        //}
        
    }
}
