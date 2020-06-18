using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{//destroy enemy when hit object whith lava tag
    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lava")
        {
             if (bDestroySelf)
                Destroy(this.gameObject);
            if (bDestroyOther)
                Destroy(collision.gameObject);
        }
    } 
}
