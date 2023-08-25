using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SpawnText : MonoBehaviour
{
    public SpriteRenderer sprite;
   
    void Start()
    {
       sprite.DOFade(0f, 0.2f).SetLoops(-1,LoopType.Yoyo);
    }

}
