using UnityEngine.Audio;
using UnityEngine;


public class MenuMusic : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MenuNCredits");
    }


}
