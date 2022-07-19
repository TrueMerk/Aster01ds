using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = true;
    public GameObject pauseMenuUI;
    private bool gameStarted = false;
    [SerializeField] private GameObject _button;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;
        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }

        if (gameStarted == false)
        {
            _button.gameObject.SetActive(false);
        }
        else
        {
            _button.gameObject.SetActive(true);
        }
    }

    private void Start()
    {
        gameStarted = false;
        pauseMenuUI.SetActive(true);
        _button.gameObject.SetActive(false);
    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;
        gameStarted = true;
    }
}
