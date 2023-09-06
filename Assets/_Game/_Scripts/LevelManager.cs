using UnityEngine;
using Lean.Pool;
using API.UI;
using System.Collections;
public class LevelManager : Singleton<LevelManager>
{
    public int AllLevelCount = 10;
    [SerializeField] int id;
    GameObject map;
    void Start()
    {
        CanvasManager.Ins.id = PlayerPrefs.GetInt("idMap");
        PlayerPrefs.SetInt("idMap", CanvasManager.Ins.id);
        GetLevelPref();
    }
    public void GetLevelPref()
    {
        LeanPool.Spawn(Resources.Load<GameObject>("stages/Stage" + PlayerPrefs.GetInt("idMap")), new Vector3(0f, 1.5f, 0f), Quaternion.identity, this.transform);
        
        CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
    }
  
}
