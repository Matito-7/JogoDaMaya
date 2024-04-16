using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    private bool isPause;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseScreen();
        }
    }

    public void PauseScreen()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            pause.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            pause.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        isPause = false;
        Time.timeScale = 1;
        pause.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
