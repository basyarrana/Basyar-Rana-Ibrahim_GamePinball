using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{   
    
    public Button mainmenuButtton;

    private void Start()
    {
        mainmenuButtton.onClick.AddListener(MainMenu);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
