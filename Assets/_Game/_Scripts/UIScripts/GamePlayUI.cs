using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : BaseUIMenu
{

    [SerializeField] Button settingBtn;

    private void Start()
    {
        settingBtn.onClick.AddListener(SettingBtn);
    }

    public void SettingBtn()
    {
        CanvasManager.Ins.OpenUI(UIName.LevelUI, null);
        Close();
    }
}
