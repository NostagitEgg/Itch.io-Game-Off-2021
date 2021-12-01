using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateAnimation : MonoBehaviour
{
    public GameObject webbody;
    public GameObject spiderbody;
    public Animator web;
    public Animator spider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Trigger")
        {
            webbody.SetActive(true);
            web.Play("WebIntro");
        }
    }

    private void Update()
    {
        if (webbody.activeSelf == true && web.GetCurrentAnimatorStateInfo(0).IsName("WebIntro") && web.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            spiderbody.SetActive(true);
            spider.Play("SpiderIntro");
        }

        if(spiderbody.activeSelf == true && spider.GetCurrentAnimatorStateInfo(0).IsName("SpiderIntro") && spider.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }

    }
    //thx to brackey's yt tutorial for the transitions
    public Animator transitions;
    IEnumerator LoadLevel(int levelIndex)
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }

}
