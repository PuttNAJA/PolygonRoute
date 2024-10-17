using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public ScoreManager ScoreManager;

    public void Play()
    {
        SceneManager.LoadScene("InGameScene");
        ScoreManager.scoreCount = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("InGameScene");
        ScoreManager.scoreCount = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void Win()
    {
        SceneManager.LoadScene("Score");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }


    public void Quit()
    {
        Application.Quit();
    }
}
