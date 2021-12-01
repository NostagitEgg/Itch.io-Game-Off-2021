using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtainfood : MonoBehaviour
{

    //collecting the Food and points (credits to Coco code's tutorial) 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ant")
        {
            //Get Food point
            ScoreManager.instance.AddScore();
            FindObjectOfType<AudioManager>().Play("FoodCollect");

            //Destroy gameobject upon touch
            Destroy(gameObject);
        }
    }

}
