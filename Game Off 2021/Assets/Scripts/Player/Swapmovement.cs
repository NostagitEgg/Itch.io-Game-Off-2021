using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swapmovement : MonoBehaviour
{
    public Camera cam;
    public Transform newPos;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Ant").GetComponent<Movement1>().enabled = true;
        GameObject.Find("Ant").GetComponent<Movement2>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "swap" && collision.gameObject.name != "Dialogue1")
        {
            GameObject.Find("Ant").GetComponent<Movement1>().enabled = false;
            GameObject.Find("Ant").GetComponent<Movement2>().enabled = true;

            cam.transform.position = newPos.transform.position;
            GameObject.Find("Main Camera").GetComponent<FollowPlayer>().enabled = false;
        }

        
    }


}
