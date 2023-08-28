using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : BaseUIMenu
{
    [SerializeField] Button playBtn;
    private void Start()
    {
        playBtn.onClick.AddListener(PlayButton);
    }
    public void PlayButton()
    {
        CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
        
        Close();
    }
}
