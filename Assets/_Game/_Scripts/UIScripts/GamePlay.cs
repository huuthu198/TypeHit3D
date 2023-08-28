using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : BaseUIMenu
{

    [SerializeField] Button settingBtn;

    private void Start()
    {
        settingBtn.onClick.AddListener(SettingButton);
    }

    public void SettingButton()
    {
        CanvasManager.Ins.OpenUI(UIName.LevelUI, null);
        Close();
    }
}
