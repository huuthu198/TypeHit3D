using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform aPos, bPos;
    // Start is called before the first frame update
    void Start()
    {
        aPos.DOMove(new Vector3(2,0,0),2).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
        bPos.DOMove(new Vector3(-2, 0, 0), 2).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

}
