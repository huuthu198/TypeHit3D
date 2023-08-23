using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int id;
    // Start is called before the first frame update
    void Start()
    {
        GameObject map = LeanPool.Spawn(Resources.Load<GameObject>("stages/Stage" + id),new Vector3(0f,1.5f,0f),Quaternion.identity,null);
    }

}
