using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        UIManager.Ins.OpenUI<LoadingUI>();
    }
}
