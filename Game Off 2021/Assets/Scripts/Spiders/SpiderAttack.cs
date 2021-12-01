using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
    public GameObject Spider;
    public Animator anim;
    public SpriteRenderer Spidersr;

    // Start is called before the first frame update
    void Start()
    {      
        anim = GetComponent<Animator>();
        Spidersr = GetComponent<SpriteRenderer>();
    }
   
    public void DisappearS()
    {
        if (gameObject.name == "Spider(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Spider (1)(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Spider (2)(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Spider (3)(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
