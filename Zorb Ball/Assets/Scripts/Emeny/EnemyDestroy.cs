using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    public ParticleSystem deathParticle;

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
    void Destroy()
    {
        Instantiate(deathParticle, transform.position,
            Quaternion.identity);
    }
}
