using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    [SerializeField] float time = 3;

    Rigidbody[] items;
    [SerializeField] float radius;

    [SerializeField] float Power;

    private void Start()
    {
        items = FindObjectsOfType<Rigidbody>();
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            Expload();
        }
    }

    private void Expload()
    {
        foreach(var item in items)
        {
            float distance = Vector3.Distance(transform.position, item.position);
           
            if (distance < radius)
            {
                Vector3 direction = item.position - transform.position;

                item.AddForce(direction.normalized * Power * (radius - distance), ForceMode.Impulse);
            }
        }

        time = 3;

    }
}
