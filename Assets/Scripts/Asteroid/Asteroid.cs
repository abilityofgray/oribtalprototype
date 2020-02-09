using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {

        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.AddForce(transform.forward * 1.5f * _rigidBody.mass, ForceMode.Impulse);

    }

    
}
