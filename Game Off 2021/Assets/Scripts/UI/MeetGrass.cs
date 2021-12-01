using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeetGrass : MonoBehaviour
{
    public Animator grass;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("Main Camera").GetComponent<FollowPlayer>().enabled = false;
            GameObject.Find("Ant").GetComponent<Movement1>().enabled = false;
            grass.SetTrigger("Menacing");
            FindObjectOfType<AudioManager>().Play("Bossdebut");
        }
    }

    private void Update()
    {
        if (grass.GetCurrentAnimatorStateInfo(0).IsName("Grasshopperdebut") && grass.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
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
