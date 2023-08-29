using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : BaseUIMenu
{
    public static Level Ins;
    [SerializeField] RectTransform container;
    [SerializeField] GameObject buttonPrefab;

    private void Awake()
    {
        Ins = this;
        OnInit();
    }

    void OnInit()
    {
        for (int i = 1; i <= LevelManager.Ins.AllLevelCount; i++)
        {
            GameObject go = Instantiate(buttonPrefab, container);
            ButtonData data = go.GetComponent<ButtonData>();
            data.textMeshProUGUI.text = i.ToString();
        }
    }
    public void Btn()
    {
        CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
        Close();
    }
   
}
