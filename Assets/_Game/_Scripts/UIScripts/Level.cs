using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : UICanvas
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
        UIManager.Ins.OpenUI<GamePlay>();
        gameObject.SetActive(false);
    }
   
}
