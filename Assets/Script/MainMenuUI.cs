using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButtton;
    public Button exitButton;

    private void Start() 
    {
        playButtton.onClick.AddListener(PlayGame);   
        playButtton.onClick.AddListener(ExitGame); 
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("PinballGame");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
