﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    [SerializeField] GameObject pauseMenu;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else{
                PauseGame();

            }
        }
    }
 public void ResumeGame()
    {
         pauseMenu.SetActive(false);
         Time.timeScale = 1f;
         isPaused = false;
    }
    void PauseGame()
    {
         pauseMenu.SetActive(true);
         Time.timeScale = 0f;
         isPaused = true;
    }
    public void  loadmenu ()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Menu");
    }


  

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
 
 
}
