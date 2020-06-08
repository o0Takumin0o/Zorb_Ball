﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject Create;

    [SerializeField]
    float fTimeIntervals;

    [SerializeField]
    Vector3 SpawnPos;

    float Timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Timer = fTimeIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = fTimeIntervals;

            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * SpawnPos.x * 
                (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * SpawnPos.z * 
                (Random.value - 0.5f);
            v3SpawnPos += Vector3.up * SpawnPos.y * 
                (Random.value - 0.5f);
            Instantiate(Create, v3SpawnPos, Quaternion.identity);
        }
    }
}