using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void QuitGame()
    {
        Application.Quit();
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
