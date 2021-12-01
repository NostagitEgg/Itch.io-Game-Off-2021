using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{

    public GameObject grasshopperDead;
    public Animator Gdie;

    // Update is called once per frame
    void Update()
    {
        if (grasshopperDead.activeSelf == true && Gdie.GetCurrentAnimatorStateInfo(0).IsTag("Win") && Gdie.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
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
