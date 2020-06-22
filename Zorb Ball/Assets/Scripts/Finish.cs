using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    Collider F_Collider;

    public Point point;
    public GameObject VfxWin;
    void Start()
    {//Fetch the GameObject's Collider 
        F_Collider = GetComponent<Collider>();
        VfxWin.SetActive(false);
    }

    void Update()
    {
        if (point.killCount == 5)
        {//enable collider when player get 5 point
            F_Collider.enabled = true;
            VfxWin.SetActive(true);
            Debug.Log("Collider.enabled = true");
        }       
    }
}
