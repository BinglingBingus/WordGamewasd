using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLetter : MonoBehaviour
{
    
    
    [SerializeField]    GameObject  W;
                public Transform[]  LetterSpawn;
                        Vector3     LetterSpawn1;
    // Start is called before the first frame update
    void Start()
    {
        
        LetterSpawn1 = LetterSpawn[0].position;
        LetterSpawn1.x += 8.05f;
        LetterSpawningSystem();
    }

    void LetterSpawningSystem()
    {
        
        Instantiate(W,LetterSpawn[0].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[1].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[2].position,Quaternion.identity);
        Instantiate(W,LetterSpawn[3].position,Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
