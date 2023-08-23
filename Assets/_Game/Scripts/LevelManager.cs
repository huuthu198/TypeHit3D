using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int id =0;

    // Start is called before the first frame update
    void Start()
    {

        UIManager.Ins.id = PlayerPrefs.GetInt("idMap");
        PlayerPrefs.SetInt("idMap", UIManager.Ins.id);
        GetLevelPreb();
    }

    private void GetLevelPreb()
    {
        GameObject map = LeanPool.Spawn(Resources.Load<GameObject>("stages/Stage" + PlayerPrefs.GetInt("idMap")), new Vector3(0f, 1.5f, 0f), Quaternion.identity, null);
    }
}
