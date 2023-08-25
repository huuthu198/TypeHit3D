using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using TMPro;
using UnityEngine.Rendering.VirtualTexturing;

public class GameController : Singleton<GameController>
{
    public List<Transform> spawnText;
    public List<GameObject> listAlphabet = new List<GameObject>();
    public AlphabetType alphabetType;
    private  int currentInput = 0;

 
    public void SpawnLetter()
    {
     
       for(int i = 0; i < listAlphabet.Count; i++)
       {
            if (listAlphabet[i].GetComponent<LetterManager>().alphabet == alphabetType) 
            {
                var letter = LeanPool.Spawn(listAlphabet[i]);
                letter.transform.position = spawnText[currentInput].position;
                currentInput++;
            }
       }
        
    }

}

public enum AlphabetType
  {
    q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m
  }


