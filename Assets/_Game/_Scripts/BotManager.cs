using API.UI;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : Singleton<BotManager>
{
    public List<Bot> Bots;
    [SerializeField] 
    float delayWinTime = 1f;

    public void CheckBots()
    {
        bool checker = false;
        Sequence mySequence = DOTween.Sequence()
        .AppendCallback(() =>
        {
            foreach (Bot bot in Bots)
                if (bot.IsHit == false)
                {
                    checker = true;
                    break;
                }
        })
        .OnComplete(() => 
        {
            if (checker == false)
                StartCoroutine(OpenCanvasAfterDelay());
        });
    }

    private IEnumerator OpenCanvasAfterDelay()
    {
        yield return new WaitForSeconds(delayWinTime);
        CanvasManager.Ins.OpenUI(UIName.WinUI, null);
    }
}
