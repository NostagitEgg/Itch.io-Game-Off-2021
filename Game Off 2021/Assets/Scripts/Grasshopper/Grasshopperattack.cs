using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grasshopperattack : MonoBehaviour
{
    //random attack, credits to Comp 3 Interactive's yt tutorial
    private Animator anim;
    public GameObject AttackLeft;
    public GameObject AttackRight;
    public GameObject AttackSides;

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(1.8f);

            anim.SetInteger("AttackIndex", Random.Range(0, 3));
            anim.SetTrigger("Attack");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grasshopper_AttackLeft"))
        {
            AttackLeft.SetActive(true);
            
        }

        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grasshopper_AttackRight"))
        {
            AttackRight.SetActive(true);
          
        }

        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grasshopper_Attack3"))
        {
            AttackSides.SetActive(true);
            
        }

 
    }

}
