using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPunch : MonoBehaviour
{
    [SerializeField] float force;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody != null && collision.gameObject.layer == 7)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.transform.position - transform.position) * force * 10, ForceMode.Impulse);
        }
    }


}
