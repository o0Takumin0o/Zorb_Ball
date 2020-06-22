using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    public float speed;
    private Rigidbody rigidbody;
    public GameObject WinScreen;
    public GameObject GameplayUI;
    public SlowTime slowTime;

    private void Awake()
    {  
        Time.timeScale = 1f;
    }

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider hitCollider)
    {//enable win screen and disable game UI
        if (hitCollider.tag == "Finish")
        {
            WinScreen.SetActive(true);
            GameplayUI.SetActive(false);
            slowTime.Endlevel = false;
        }
    }
    
}
    

