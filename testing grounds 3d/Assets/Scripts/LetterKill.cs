using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterKill : MonoBehaviour
{
    public string[] Letters;
    int scorepoints;
    Vector3 ThisPosLeft;
    Vector3 ThisPosRight;
    
    string ThisLetter;
    // Start is called before the first frame update
    void Start()
    {
        scorepoints = 50;
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
        ThisPosLeft = GetComponent<Transform>().position ;
        ThisPosLeft.x -= 4.025f;
        ThisPosRight = GetComponent<Transform>().position ;
        ThisPosRight.x -= -4.025f;
        Collider[] SpawnOccupiedLeft = Physics.OverlapSphere(ThisPosLeft,0.5f);
        Debug.Log(SpawnOccupiedLeft.Length);

        Collider[] SpawnOccupiedRight = Physics.OverlapSphere(ThisPosRight,0.5f);
    
            if(Input.GetKeyDown(ThisLetter) && SpawnOccupiedLeft.Length == 0 && SpawnOccupiedRight.Length == 0)
            {
            GameObject Meth =  GameObject.Find("LetterSpawnSystem");
            SpawnLetter letterspawn = Meth.GetComponent<SpawnLetter>();
                letterspawn.enabled = true;
                Debug.Log("works");
                Destroy(gameObject);
            }

            if(Input.GetKeyDown(ThisLetter) && SpawnOccupiedLeft.Length == 0)
        {
           Scoreinfo ScoreIn = GetComponent<Scoreinfo>();
           ScoreIn.scoresystem(scorepoints);
         Destroy(gameObject);
        }
    }
}
