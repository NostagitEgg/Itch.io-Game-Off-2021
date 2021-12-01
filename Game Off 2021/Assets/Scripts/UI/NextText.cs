using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextText : MonoBehaviour
{
    public Image logos;
    public Animator logo;

    public Animator textAnim;

    public Animator textAnim1;
    bool started;
    public void DeactivateLogos()
    {
        logos.enabled = false;
        textAnim.SetTrigger("Text");
    }

    public void NextIn()
    {
        textAnim1.SetTrigger("bug");
        started = true;
    }

    void Update()
    {
        if (started == true && textAnim1.GetCurrentAnimatorStateInfo(0).IsName("buggymation") && textAnim1.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }

    public Animator transitions;

    IEnumerator LoadLevel(int levelIndex)
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }
}
