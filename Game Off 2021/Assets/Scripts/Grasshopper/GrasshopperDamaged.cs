using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrasshopperDamaged : MonoBehaviour
{
    //thx to brackeys for the healthbar yt tutorial
    public int maxHealth = 100;
    public int currentHealth;

    public GrasshopperHealth healthbar;
    public GameObject grasshopper;
    public GameObject grasshopperDead;
    public Animator Gdie;

    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxhealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (triggered && Input.GetMouseButtonDown(0))
        {
            takeDamage(1);
        }

        if (currentHealth == 0)
        {
            
            grasshopper.SetActive(false);
            grasshopperDead.SetActive(true);
        }

        if(grasshopperDead.activeSelf == true)
        {
            Gdie.SetTrigger("Death");
            FindObjectOfType<AudioManager>().Play("BossWin");
        }
    }

    public Animator grasshopperAnim;
    void takeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);

        grasshopperAnim.SetTrigger("GetHurt");
        FindObjectOfType<AudioManager>().Play("BossDamage");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            triggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }

    

}
