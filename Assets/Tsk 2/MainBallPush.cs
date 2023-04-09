using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBallPush : MonoBehaviour
{
    [SerializeField] private float force;

    void Start()
    {
        

        GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
            
 
            
    }

}
