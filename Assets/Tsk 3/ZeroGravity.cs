using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravity : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Rigidbody>() != null)
        {
            collider.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
            

    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<Rigidbody>() != null)
            collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
