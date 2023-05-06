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
    float   timer;
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
        ThisPosUp       =       ThisLetterTran.position;
        ThisPosUp.y     -=      -4.025f;
        ThisPosDown     =       ThisLetterTran.position;
        ThisPosDown.y   -=      4.025f;


        Collider[] SpawnOccupiedDown    = Physics.OverlapSphere(ThisPosDown, 1f);
        Collider[] SpawnOccupiedUp      = Physics.OverlapSphere(ThisPosUp, 1f);
        Collider[] SpawnOccupiedRight   = Physics.OverlapSphere(ThisPosRight,0.5f);
        Collider[] SpawnOccupiedLeft    = Physics.OverlapSphere(ThisPosLeft,0.5f);
        //if nothing is below then change colour and wait for entire above row to be empty and then go up
        //Debug.Log(SpawnOccupiedDown[0]);
        if(SpawnOccupiedUp.Length == 1 && SpawnOccupiedRight.Length == 0 && SpawnOccupiedDown.Length == 1)
            {
            ThisLetterTran.position = ThisPosUp;
            
            GetComponent<TMP_Text>().color = Color.green;
            GameObject Meth =  GameObject.Find("LetterSpawnSystem");
            SpawnLetter letterspawn = Meth.GetComponent<SpawnLetter>();
            letterspawn.enabled = true;
            }
        if(SpawnOccupiedUp.Length == 2)
        {
            
            GetComponent<TMP_Text>().color = Color.gray;
            GetComponent<TMP_Text>().alpha = 0.1f;

        }
        if(SpawnOccupiedDown.Length == 2) // Execute normal code
        {
        
        Debug.Log(SpawnOccupiedDown.Length);
        GetComponent<TMP_Text>().color = Color.green;

        
        //This is checking if left of letter is occupied
            if(Input.GetKeyDown(ThisLetter) && SpawnOccupiedLeft.Length == 0)
            {

           GameObject ScoreGameObject = GameObject.Find("EnemyLetter Variant 1");
           Scoreinfo ScoreINF =  ScoreGameObject.GetComponent<Scoreinfo>();
           ScoreINF.scoresystem(scorepoints);
           Destroy(gameObject);
            }
        //This is checking if left and right of letter is occupied and then enabling LettterSpawn
            if(Input.GetKeyDown(ThisLetter) && SpawnOccupiedLeft.Length == 0 && SpawnOccupiedRight.Length == 0)
            {
            //GameObject Meth =  GameObject.Find("LetterSpawnSystem");
            //SpawnLetter letterspawn = Meth.GetComponent<SpawnLetter>();
                //letterspawn.enabled = true;
                Debug.Log("works");
                Destroy(gameObject);
            }
        


        }

    }
}
