using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainFoodIntro : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ant")
        {
            FindObjectOfType<AudioManager>().Play("FoodCollect");
            this.gameObject.SetActive(false);
        }
    }
 
}
