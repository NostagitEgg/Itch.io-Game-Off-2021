using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderParaAttack : MonoBehaviour
{
    //this was initially a script for a jumping spider, but its a web now
    //thanks to Comp 3 Interactive's yt tutorial of animation events
    public GameObject Web;
    public Animator anim;
    public SpriteRenderer websr;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        websr = GetComponent<SpriteRenderer>();
    }

    public void Disappear()
    {
        if(gameObject.name == "Web(Clone)")
        {
            Destroy(gameObject);
        }
        
    }
}
