using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private List<Bot> bots;
    private int currentBot ;
    void Init()
    {
        for(int i = 0; i <= bots.Count; i++)
        {
          
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alphabet"))
        {
            CanvasManager.Ins.OpenUI(UIName.WinUI, null);
            
        }
    }
}
