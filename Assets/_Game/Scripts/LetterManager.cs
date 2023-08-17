using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;


public class LetterManager : MonoBehaviour
{
    public TextMeshPro m_TextMeshPro;

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            Debug.Log("Die");
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
           
        }
    }
}
