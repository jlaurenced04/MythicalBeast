using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int  PlayGameIndex = 1;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(PlayGameIndex);
    }
    public void QuitGame()
    {
        Debug.Log("Application Quitted");
        Application.Quit();
    }
 
}
