using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLetter : MonoBehaviour
{
    
    
    [SerializeField]    GameObject  W;
                public Transform[]  LetterSpawn;
                public  Vector3[]   GhostLetterSpawn;
    // Start is called before the first frame update
    void Start()
    {

        //LetterSpawn1 = LetterSpawn[0].position;
        //LetterSpawn1.x += 8.05f;
        LetterSpawningSystem();
    }
    void OnEnable()
    {
        
       // LetterSpawn1        = LetterSpawn[0].position;
       // LetterSpawn1.x      += 8.05f;

        LetterSpawningSystem();
        Debug.Log("Enabled");
    }

    void LetterSpawningSystem()
    {
        
        Instantiate(W,LetterSpawn[0].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[1].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[2].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[3].position,Quaternion.identity);
        Instantiate(W,GhostLetterSpawn[0],Quaternion.identity);
        Instantiate(W,GhostLetterSpawn[1],Quaternion.identity);
        Instantiate(W,GhostLetterSpawn[2],Quaternion.identity);
        Instantiate(W,GhostLetterSpawn[3],Quaternion.identity);

        GetComponent<SpawnLetter>().enabled = false;
    }
    // Update is called once per frame

}
