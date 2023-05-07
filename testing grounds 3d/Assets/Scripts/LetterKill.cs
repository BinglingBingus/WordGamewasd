using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterKill : MonoBehaviour
{
    public string[] Letters;
    int scorepoints;
    Transform ThisLetterTran;
    Vector3 ThisPosLeft;
    Vector3 ThisPosRight;
    Vector3 ThisPosUp;
    Vector3 ThisPosDown;  
    string ThisLetter;
    public string NotThisLetter;
    // Start is called before the first frame update
    void Start()
    {
        scorepoints = 10;
        SetThisLetter();
        
    }

    // Update is called once per frame
    void Update()
    {
        KillThisLetter();
    }

    void SetThisLetter()
    {
        int LettersRange = Mathf.RoundToInt(Random.Range(0f, Letters.Length-1));
        ThisLetter = Letters[LettersRange];
        GetComponent<TMP_Text>().text = ThisLetter;
    }
    void KillThisLetter()
    {
        
    //Checks if space left is occupied
    ThisLetterTran = GetComponent<Transform>() ;

        ThisPosLeft     =       ThisLetterTran.position;
        ThisPosLeft.x   -=      4.025f;
        ThisPosRight    =       ThisLetterTran.position;
        ThisPosRight.x  -=      -4.025f;
        ThisPosUp       =       ThisLetterTran.position;                                    //wip
        ThisPosUp.y     -=      -4.025f;                                                    //wip
        ThisPosDown     =       ThisLetterTran.position;                                    //wip
        ThisPosDown.y   -=      4.025f;                                                     //wip


        Collider[] SpawnOccupiedDown    = Physics.OverlapSphere(ThisPosDown, 1f);           //wip
        Collider[] SpawnOccupiedUp      = Physics.OverlapSphere(ThisPosUp, 1f);             //wip
        Collider[] SpawnOccupiedRight   = Physics.OverlapSphere(ThisPosRight,0.5f);
        Collider[] SpawnOccupiedLeft    = Physics.OverlapSphere(ThisPosLeft,0.5f);
        Collider[] SpawnOccupiedArea    = Physics.OverlapSphere(ThisLetterTran.position, 20f);
        

        //if nothing is below then change colour and wait for entire above row to be empty and then go up
        //Debug.Log(SpawnOccupiedDown[0]);
        //if(SpawnOccupiedUp.Length == 1 && SpawnOccupiedRight.Length == 0 && SpawnOccupiedDown.Length == 1)
        if(SpawnOccupiedArea.Length == 7)
            {
            
            GetComponent<TMP_Text>().color = Color.green;
            ThisLetterTran.position = ThisPosUp;

            if(SpawnOccupiedRight.Length == 0)
            {
            GameObject Meth =  GameObject.Find("LetterSpawnSystem");
            SpawnLetter letterspawn = Meth.GetComponent<SpawnLetter>();
            letterspawn.enabled = true;
            }


            }
        if(SpawnOccupiedUp.Length == 2)
        {
            
            GetComponent<TMP_Text>().color = Color.gray;
            GetComponent<TMP_Text>().alpha = 0.8f;

        }
        if(SpawnOccupiedDown.Length == 2) // Execute normal code
        {
        
        GetComponent<TMP_Text>().color = Color.green;

        
        // This is base game
        //This is checking if left of letter is occupied
            if(Input.GetKeyDown(ThisLetter) && SpawnOccupiedLeft.Length == 0)
            {

           GameObject ScoreGameObject = GameObject.Find("Score");
           Scoreinfo ScoreINF =  ScoreGameObject.GetComponent<Scoreinfo>();
           ScoreINF.scoresystem(scorepoints);
           Destroy(gameObject);
            }
            if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
            {
            NotThisLetter = Input.inputString;
            if(NotThisLetter != ThisLetter && SpawnOccupiedLeft.Length ==0)
            {
                    Debug.Log("wrong key");
        GameObject ScoreGameObject = GameObject.Find("Score");
           Scoreinfo ScoreINF =  ScoreGameObject.GetComponent<Scoreinfo>();
           ScoreINF.scoresystem(-scorepoints *5);
                    
            }
            }
        }

    }
}
