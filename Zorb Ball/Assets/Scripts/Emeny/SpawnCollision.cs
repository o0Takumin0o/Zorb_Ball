using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollision : MonoBehaviour
{ // spawn enemy death effect when enemy hit this object
    [SerializeField]
    bool bSpawnSelf = false;

    [SerializeField]
    bool bSpawnOther = false;

    [SerializeField]
    GameObject goSpawn;

    private void OnCollisionEnter(Collision collision)
    {
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
