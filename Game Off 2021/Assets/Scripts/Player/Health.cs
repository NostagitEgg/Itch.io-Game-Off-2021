using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //Health system, credits to BlackThornProd's yt tutorial
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject GameOver;
    public GameObject ant;

    public Animator antim;
  
    // Update is called once per frame
    void Update()
    {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        //Game Over
        if (health == 0)
        {
            GameOver.SetActive(true);
            ant.SetActive(false);
            Time.timeScale = 0.0001f;
            Cursor.visible = true;
        }
    }

    public void LoseHealth()
    {
        health += -1;
        antim.SetTrigger("Hurt");
        FindObjectOfType<AudioManager>().Play("Hurt");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Web(Clone)")
        {
            LoseHealth();
        }

        if (collision.gameObject.tag == "SpiderAttack")
        {
            LoseHealth();
        }

        if (collision.gameObject.tag == "Boss")
        {
            LoseHealth();
        }
    }
}
