using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    Animator animator;

    //
    [SerializeField] bool pressMe;
    //

    public bool IsHit = false;

    void Awake() => animator = GetComponent<Animator>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alphabet") && !IsHit)
        {
            IsHit = true;
            //------------------------------
            if (!pressMe)
            //------------------------------

                animator.Play("Die", 0, 0.25f);

            //------------------------------
            else
                animator.Play("Die", 0, 1f);
            //------------------------------

            BotManager.Ins.CheckBots();
        }
    }
}
