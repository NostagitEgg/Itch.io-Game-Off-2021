using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWarnings : MonoBehaviour
{
    //This might've been done in a more efficient and conventional way but eh
    //to stop the warning animations after the attack of the grasshopper
    public GameObject AttackLeft;
    public GameObject AttackRight;
    public GameObject AttackSides;
    public Animator ATLeft;
    public Animator ATRight;
    public Animator ATSides;

    void DestroyAtLeft()
    {
        AttackLeft.SetActive(false);
    }

    void DestroyAtRight()
    {
        AttackRight.SetActive(false);
    }

    void DestroyAtsides()
    {
        AttackSides.SetActive(false);
    }

}
