using API.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppParent : Singleton<AppParent>
{
    void Start()
    {
        Application.targetFrameRate = 60;

        Action onLoaded = () =>
        {
            //CanvasManager.Ins.CloseUI(UIName.LoadingUI);
            CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
        };
        CanvasManager.Ins.OpenUI(UIName.LoadingUI, new object[] { onLoaded });
    }
}
