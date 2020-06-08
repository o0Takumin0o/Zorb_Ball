using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour
{
    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 2);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
