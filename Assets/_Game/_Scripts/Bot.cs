using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alphabet"))
        {
            UIManager.Ins.OpenUI<Win>();
        }
    }
}
