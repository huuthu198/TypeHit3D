using API.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Win : BaseUIMenu
{
    [SerializeField] Button nextBtn;

    private void Start()
    {
        nextBtn.onClick.AddListener(NextBtn);
    }
    public void NextBtn()
    {
        PlayerPrefs.SetInt("idMap", PlayerPrefs.GetInt("idMap")+1);
       
        SceneManager.LoadScene(0);
    }

}
