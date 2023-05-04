using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordEnemy : MonoBehaviour
{
    public TMP_Text canvasTextWord;
 
    // public TMP_Text worldText;
    // Update is called once per frame
    public string remainingWord = string.Empty;
    public string currentWord = "wasd";

    void Start()
    {
        
        
    }

    void Update()
    {
        

    }
    
    void  settheword()
    {
        
        canvasTextWord.text   = remainingWord;
        
    }

    void something()
    {

       if(remainingWord.Substring(0, 1) == "w")
        {
            currentWord.Remove(0);
        }

    }

}

