using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    [SerializeField]
    Transform transTowards;
    [SerializeField]
    float fSpeed;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (transTowards == null)
        {
            transTowards = FindObjectOfType<PlayerCtrl>()
                .transform;
        }
    }
    void Update()
    {
        Vector3 moveTowardsTarget = transTowards.position -
            transform.position;
        rigid.velocity += moveTowardsTarget.normalized *
            fSpeed * Time.deltaTime;
    }
}
