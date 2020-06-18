using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text killTxt;
    [SerializeField]
    public int killCount;
    private void OnCollisionEnter(Collision collision)
    {//add point when hit enemy 
        if (collision.collider.tag == "Enemy")
        {
            killCount++;
        }
        killTxt.text = "KillCount :"+ killCount.ToString();
    }
}
