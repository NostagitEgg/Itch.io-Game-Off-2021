using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    //WASD movement credits to Brackey's yt tutorial

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator anim;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            rb.SetRotation(0);
            anim.SetTrigger("Walk");
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.SetRotation(90);
            anim.SetTrigger("Walk");
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.SetRotation(-90);
            anim.SetTrigger("Walk");
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.SetRotation(180);
            anim.SetTrigger("Walk");
        }
    }
}
