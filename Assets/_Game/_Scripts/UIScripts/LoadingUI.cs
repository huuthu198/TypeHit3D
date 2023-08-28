using API.UI;
using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoadingUI : BaseUIMenu
{
    public Image progress;

    private void Start()
    {
        LoadingRun();
    }
    public void LoadingRun()
    {
        Time.timeScale = 1f;
        progress.fillAmount = 0;
        progress.DOFillAmount(1f, 1f).SetEase(Ease.Linear).OnComplete(() =>
        {
            CanvasManager.Ins.OpenUI(UIName.MainMenuUI, null);
            gameObject.SetActive(false);
        });
    }
}
