using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public bool IsHit = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alphabet"))
        {
            IsHit = true;
            BotManager.Ins.CheckBots();
        }
    }
}
