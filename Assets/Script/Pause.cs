using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject UIpause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1f)
            {
                PauseGame();
            }
            else 
            {
                Resume();
            }
        }

    }

    public void Resume()
    { 
        UIpause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        UIpause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
