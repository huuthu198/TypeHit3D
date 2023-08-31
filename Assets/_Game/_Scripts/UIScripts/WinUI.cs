using API.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WinUI : BaseUIMenu
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
