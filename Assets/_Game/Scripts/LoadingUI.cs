using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingUI : UICanvas
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
        progress.DOFillAmount(1f, 3f).SetEase(Ease.Linear).OnComplete(() =>
        {
            UIManager.Ins.OpenUI<MainMenu>();
            gameObject.SetActive(false);
        });
    }
}
