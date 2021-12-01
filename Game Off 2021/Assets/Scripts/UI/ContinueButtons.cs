using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButtons : MonoBehaviour
{
    public Animator transitions;

    public void Level1()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        StartCoroutine(LoadLevel1());
    }

    IEnumerator LoadLevel1()
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Level1");

    }

    public void Boss()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        StartCoroutine(LoadBoss());
    }

    IEnumerator LoadBoss()
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Boss Level");

    }

    public void Back()
    {
        FindObjectOfType<AudioManagerMenu>().Play("Button");
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Menu");

    }



}
