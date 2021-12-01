using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    //transitions for loading thx to Brackey's yt tutorial
    public Animator transitions;
    public void Play()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        Application.Quit();
    }

    public void Continue()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 6));
    }
}
