using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class GameController : MonoBehaviour
{
   
    public static GameController instance;
   
    public GameObject spawn ;
    public List<string> strings;

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
       var Letter = LeanPool.Spawn(spawn);
       Letter.transform.position = Vector3.zero;
        
    }

   public void CheckAlphaBet(TypeList typeList)
   {
        
   }
       
}
public enum TypeList
{
  q,
  w,
  e,
  r,
  t,
  y,
  u,
  i,
  o,
  p
}


