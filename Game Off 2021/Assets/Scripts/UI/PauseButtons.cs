using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour
{
    bool isPaused;
    public GameObject PauseScrn;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && isPaused == false)
        {
            FindObjectOfType<AudioManager>().Play("Button");
            PauseScrn.SetActive(true);
            Time.timeScale = 0.001f;
            isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }

    public void PauseIcon()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        if(isPaused == false)
        {
            PauseScrn.SetActive(true);
            Time.timeScale = 0.001f;
            isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            PauseScrn.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        PauseScrn.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        
    }
    
    public void QuitLevel()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        Cursor.visible = true;
    }
}
