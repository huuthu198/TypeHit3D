using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonData : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public Image levelState;
    public Button button;
    public void SpawnLevel()
    {
        //Destroy level hien tai
        foreach (Transform child in LevelManager.Ins.transform)
            Destroy(child.gameObject); 
        // Select level
        LeanPool.Spawn(Resources.Load<GameObject>("stages/Stage" + textMeshProUGUI.text), new Vector3(0f, 1.5f, 0f), Quaternion.identity, LevelManager.Ins.transform);

        OnclickBtn();

    }
    public void OnclickBtn()
    {
        Level.Ins.Btn();
    }
}
