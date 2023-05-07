using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    public int YourHighScore;
    public int ScoreCurrent;
    public TextMeshPro Highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        YourHighScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HighscoreSystem();
    }


    void HighscoreSystem()
    {
        GameObject Meth2 =  GameObject.Find("Score");
        Scoreinfo SCOREINF = Meth2.GetComponent<Scoreinfo>();
        ScoreCurrent = SCOREINF.Score;

        if(YourHighScore < ScoreCurrent)
        {
            YourHighScore = ScoreCurrent;
            Highscoretext.text = ScoreCurrent.ToString();
            Highscoretext.color = new Color(0,50,150);
        }
    }
}
