using API.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppParent : Singleton2<AppParent>
{
    public bool isPlaying;
    void Start()
    {
        Application.targetFrameRate = 60;

        Action onLoaded = () =>
        {
            if(isPlaying == false)
                CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
        };
        CanvasManager.Ins.OpenUI(UIName.LoadingUI, new object[] { onLoaded });
    }
}
