using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject[] credits;
    public Animator win;
    public Animator title;

    bool ended;

    private void Start()
    {
        win.Play("UWon");
    }

    public void LogoTime()
    {
        title.SetTrigger("Title");
    }

    public void Ended()
    {
        ended = true;

        if (ended == true)
        {
            StartCoroutine(HoldUp());
        }
    }

    //The credits sequence, this might not be the most conventional way but eh
    IEnumerator HoldUp()
    {
        credits[0].SetActive(true);

        yield return new WaitForSeconds(2);

        credits[0].SetActive(false);

        credits[1].SetActive(true);

        yield return new WaitForSeconds(7);

        credits[1].SetActive(false);
        
        credits[2].SetActive(true);

        yield return new WaitForSeconds(7);

        credits[2].SetActive(false);

        credits[3].SetActive(true);

        yield return new WaitForSeconds(2);

        StartCoroutine(LoadDaMenu());

    }

    public Animator transitions;

    IEnumerator LoadDaMenu()
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Menu");
        Cursor.visible = true;
    }

}
