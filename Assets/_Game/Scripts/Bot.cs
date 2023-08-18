using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Canvas winCanvas;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alphabet"))
        {
            winCanvas.gameObject.SetActive(true);
            Time.timeScale = 1.0f;
        }
    }
}
