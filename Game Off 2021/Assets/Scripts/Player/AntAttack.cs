using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntAttack : MonoBehaviour
{

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");

        }
    }
}
