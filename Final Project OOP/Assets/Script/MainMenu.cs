using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        /*Debug.Log("Exit!");*/
        Application.Quit();
    }
}
