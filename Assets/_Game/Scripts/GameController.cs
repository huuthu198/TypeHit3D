using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using TMPro;
using UnityEngine.Rendering.VirtualTexturing;

public class GameController : MonoBehaviour
{
   
    public static GameController instance;
    public GameObject q ;
    public Transform inputText;


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

    public void SpawnLatter(string t)
    {
       var Letter = LeanPool.Spawn(q);
        Letter.GetComponent<LetterManager>().m_TextMeshPro.text = t;
        Letter.transform.position = inputText.position;
    }   
}



