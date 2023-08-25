using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : Singleton<LevelManager>
{
    public int AllLevelCount = 5;
    [SerializeField] int id =0;
    public Button[] button;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.Ins.id = PlayerPrefs.GetInt("idMap");
        PlayerPrefs.SetInt("idMap", UIManager.Ins.id);
        GetLevelPref();
    }
    private void GetLevelPref()
    {
        GameObject map = LeanPool.Spawn(Resources.Load<GameObject>("stages/Stage" + PlayerPrefs.GetInt("idMap")), new Vector3(0f, 1.5f, 0f), Quaternion.identity, this.transform);
    }
}
