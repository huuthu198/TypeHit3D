using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using TMPro;
using UnityEngine.Rendering.VirtualTexturing;

public class GameController : MonoBehaviour
{
   
    public static GameController instance;
    public Transform inputText;
    public List<GameObject> listAlphabet = new List<GameObject>();
    public AlphabetType alphabetType;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }

    public void SpawnLatter()
    {
       //var Letter = LeanPool.Spawn(text);
       //Letter.transform.position = inputText.position;
       for(int i = 0; i < listAlphabet.Count; i++)
        {
            if (listAlphabet[i].GetComponent<LetterManager>().alphabet == alphabetType) 
            {
                var letter =LeanPool.Spawn(listAlphabet[i]);
                letter.transform.position = inputText.position;
            }
        }
        
     
    }
}

public enum AlphabetType
  {
    q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m
  }


