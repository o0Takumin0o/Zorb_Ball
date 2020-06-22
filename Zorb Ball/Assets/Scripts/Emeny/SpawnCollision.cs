using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollision : MonoBehaviour
{
    [SerializeField]
    bool bSpawnSelf = false;

    [SerializeField]
    bool bSpawnOther = false;

    [SerializeField]
    GameObject goSpawn;

    private void OnCollisionEnter(Collision collision)
    {// spawn enemy death effect when "Enemy" hit this object
        if (collision.collider.tag == "Enemy")
        {
            if (bSpawnSelf)
            {
                Instantiate(goSpawn, transform.position, Quaternion.identity);
            }

            if (bSpawnOther)
            {
                Instantiate(goSpawn, collision.transform.position, Quaternion.identity);
            }

        }
    }
}
