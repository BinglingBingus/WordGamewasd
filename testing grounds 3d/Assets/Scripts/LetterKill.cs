using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterKill : MonoBehaviour
{
    public string[] Letters;
    Vector3 ThisPos;
    
    string ThisLetter;
    // Start is called before the first frame update
    void Start()
    {
        SetThisLetter();
    }

    // Update is called once per frame
    void FixedUpdate()
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
        ThisPos = GetComponent<Transform>().position ;
        ThisPos.x -= 4.025f;
        Collider[] SpawnOccupied = Physics.OverlapSphere(ThisPos,0.5f);
        Debug.Log(SpawnOccupied.Length);
    

            if(Input.GetKey(ThisLetter) && SpawnOccupied.Length == 0)
        {
         Destroy(gameObject);
        }
    }
}
