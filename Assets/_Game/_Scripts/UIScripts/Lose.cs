using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : BaseUIMenu
{
    public Text score;

   public void ReplayBtn()
    {
        CanvasManager.Ins.OpenUI(UIName.GameplayUI, null);
    }
}
