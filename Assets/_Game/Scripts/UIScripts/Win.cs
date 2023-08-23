using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Win : UICanvas
{
    //public Text score;

    public void MainMenuButton()
    {
        PlayerPrefs.SetInt("idMap", PlayerPrefs.GetInt("idMap")+1);
       
        SceneManager.LoadScene(0);
    }


}
